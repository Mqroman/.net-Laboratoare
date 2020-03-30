using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Lab6_WCF_EF;

namespace ClientPostComment
{
    public partial class Form1 : Form
    {
        List<Post> posts = new List<Post>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test();
            posts = LoadPosts().ToList<Post>();
            dgp.DataSource = posts;
            dgp.Columns[0].Width = 0;

            if (dgp.Rows.Count > 0)
                dgc.DataSource = posts[0].Comments;
        }

        private static Post[] LoadPosts()
        {
            PostCommentClient pc = new PostCommentClient();
            Post[] p = pc.GetPosts();
            return p;
        }

        private void dgp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dgc.DataSource = null;
            dgc.DataSource = posts[e.RowIndex].Comments;
            dgc.Update();
            dgc.Refresh();
        }

        private void Test()
        {
            Post p1 = new Post() { Date = DateTime.Now, Description = "desc",Domain="Domain" };
            Post p2 = new Post() { Date = DateTime.Now, Description = "Description",Domain="domeniu" };
            PostCommentClient postCommentClient = new PostCommentClient();
            postCommentClient.AddPost(p1);
            postCommentClient.AddPost(p2);

            postCommentClient.AddComment(new Comment() { PostPostId = 1, Text = "nice comment" });
            postCommentClient.AddComment(new Comment() { PostPostId = 1, Text = "mean comment" });
            postCommentClient.AddComment(new Comment() { PostPostId = 2, Text = "Random comment" });
        }

 
    }
}
