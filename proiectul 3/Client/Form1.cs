using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using APIspace;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
namespace GUI
{
    public partial class Form1 : Form
    {
        //MediaClient newMediaClient = new MediaClient();
        string imgLocation = "";
        public Form1()
        {
            InitializeComponent();
            if (checkBox2.Checked == false && checkBox1.Checked == false) checkBox1.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ///in caz ca vrem sa vedem o poza
            pictureBox1.ImageLocation = "C:/Users/Utilizator 5/Desktop/wall.jpg";
            label1.Text = pictureBox1.ImageLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != Color.Red)
                button1.BackColor = Color.Red;
            else
                button1.BackColor = Color.White;

            //schimbam adresa imagini afisate
            pictureBox1.ImageLocation = textBox6.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = pictureBox1.ImageLocation;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //navigam in foldere
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();

        }



        private void button3_Click(object sender, EventArgs e)
        {

            ///deschidem o fereastra pentru a cauta imagini/filme noi
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "SELECT" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //navigam in foldere

            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            //memoram adreasa curenta pentru a facilita adaugarea/vizionarea
            textBox2.Text = webBrowser1.Url.LocalPath.ToString();
            textBox1.Text = webBrowser1.Url.LocalPath.ToString();
            textBox6.Text = webBrowser1.Url.LocalPath.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //adaugam in baza de date poze/filme
            var api = new API();
            string a1 = textBox2.Text;
            string a2 = textBox3.Text;
            string a3 = textBox4.Text;
            string a4 = checkBox1.Text;

            if (checkBox1.Checked == false)
                a4 = checkBox2.Text;

            api.AdaugaPozeAndFilme(ref a2, ref a3, ref a1, ref a4);


            //afisam baza de date pentru a fi la curent cu modificarile aduse

            DataTable drbl = new DataTable();
            api.AfisareGalerie(ref drbl);
            dataGridView1.DataSource = drbl;

            textBox3.Text = null;
            textBox4.Text = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///interogarea dupa 3 criterii 
            string gol = textBox9.Text;
            string locatia = textBox5.Text;
            string evenimentul = textBox7.Text;
            string numeP = textBox8.Text;
            string query = "select * from Galeries where ";
            string query2 = "Select * from Galeries g join Grups u on Id_galerie=Id_G join Persoanas p on Id_persoana=Id_P where nume like '";
            query2 += numeP;
            query2 += "';";


            if (textBox5.Text != gol)
            {
                query += "  locatie ='";
                query += locatia;
                query += "'";
            }

            if (textBox5.Text != gol && textBox7.Text != gol)
                query += " and ";

            if (textBox7.Text != gol)
            {
                query += " eveniment='";
                query += evenimentul;
                query += "'";
            }

            query += ";";
            if (query != "select * from Galeries where ;") query += query2;
            else query = query2;
            var api = new API();

            DataTable drbl = new DataTable();
            api.InterogareDupaCriterii(query, ref drbl);
            dataGridView1.DataSource = drbl;



        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //afisam baza de date
            var api = new API();

            DataTable drbl = new DataTable();
            api.AfisareGalerie(ref drbl);
            dataGridView1.DataSource = drbl;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            checkBox1.Checked = false;



        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //afisam dupa id
            string id_gal = textBox12.Text;
            string query = "select * from Galeries where id_galerie ='";
            query += id_gal;
            query += "';";

            var api = new API();
            DataTable drbl = new DataTable();
            api.AfisareDupaId(query, ref drbl);
            dataGridView1.DataSource = drbl;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ///adaugam persoane la poze/filme , in caz ca nu exista acea persoana o adaugam in bd

            int id_gal = Int32.Parse(textBox12.Text);
            string numeP = textBox11.Text;
            string prenumeP = textBox10.Text;

            var api = new API();
            api.AdaugaPersoaneLaId(id_gal, numeP, prenumeP);


        }

        private void button10_Click(object sender, EventArgs e)
        {

            //afisam bd a persoanelor


            var api = new API();

            DataTable drbl = new DataTable();
            api.AfisarePersoane(ref drbl);
            dataGridView1.DataSource = drbl;
        }
    }
}
