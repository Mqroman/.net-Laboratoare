

using ModelAndApi;
using System;
using System.Data;
using System.Data.SqlClient;

namespace APIspace
{
    public class API
    {

        //detaliile necesare pentru realizarea interogarilor cu baza de date
        string connectionString = @"Data Source = DESKTOP-NC8L2CK; Initial Catalog = Album; Integrated Security = True;";

        public void Salvare(string adresa, string persons, string eveniment, string locatie, string tip, DateTime creationDate)
        {
            int check = 1;
            using (var context = new Model1Container())
            {
                foreach (var data in context.Galeries)
                {
                    if (data.Adresa.ToString() == adresa)
                    {
                        check = 0;
                    }
                }

                if (check == 1)
                {
                    Galerie newMedia = new Galerie()
                    {
                        Adresa = adresa,                  
                        Eveniment = eveniment,                       
                        DataCreare = creationDate
                    };
                    context.Galeries.Add(newMedia);
                    context.SaveChanges();
                }
            }
        }

        public void Sterge(string path)
        {
            using (var context = new Model1Container())
            {
                
            }
        }

        public void AfisarePersoane(ref DataTable drbl)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Persoanas", sqlCon);
                sqlDa.Fill(drbl);


            }
        }

        public void AfisareGalerie(ref DataTable drbl)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Galeries", sqlCon);
                sqlDa.Fill(drbl);


            }
        }
        public object ShowGridData()
        {
            string result = "";
            using (var context = new Model1Container())
            {
                foreach (var data in context.Galeries)
                {
                    result = result + "ID: " + data.Id_galerie.ToString() + ";" +
                        " Data Creare: " + data.DataCreare.ToString() + "\n";
                }
            }
            return result;
        }
        public void InterogareDupaCriterii(string query, ref DataTable drbl)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(drbl);

            }
        }
        public void AfisareDupaId(string query, ref DataTable drbl)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);

                sqlDa.Fill(drbl);

            }
        }
        public void AdaugaPozeAndFilme(ref string a2, ref string a3, ref string a1, ref string a4)
        {
            using (Model1Container context = new Model1Container())
            {
                Galerie c = new Galerie()
                {

                    DataCreare = DateTime.Now,
                    Eveniment = a2,
                    Locatie = a3,
                    Adresa = a1,
                    Tip = a4
                };
                context.Galeries.Add(c);
                context.SaveChanges();

            }
        }

        public void AdaugaPersoaneLaId(int id_gal, string numeP, string prenumeP)
        {
            using (Model1Container context = new Model1Container())
            {

                int id_pal = 1;
                bool ok = false;
                var items = context.Persoanas;
                foreach (var x in items)
                    if (x.Nume == numeP && x.Prenume == prenumeP)
                    {
                        id_pal = x.Id_persoana;
                        ok = true;
                    }
                if (ok == false)//adaugam o persoana noua in bd
                {
                    Persoana pp = new Persoana()
                    {
                        Nume = numeP,
                        Prenume = prenumeP

                    };

                    context.Persoanas.Add(pp);
                    context.SaveChanges();
                    id_pal = pp.Id_persoana;

                }

                Grup c = new Grup()
                {
                    Id_G = id_gal,
                    Id_P = id_pal

                };
                context.Grups.Add(c);

                context.SaveChanges();

            }
        }
    }
}
