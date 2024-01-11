using RegisterLoginSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegisterLoginSystem
{
    public partial class FormComment : Form
    {
        public User user;
        public PostControl post;
        public static FormComment instance;
        public string Username;
        public int postid;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public FormComment(User user, PostControl post)
        {
            InitializeComponent();
            this.user = user;
            this.post = post;
            this.Username = user.Username;
            this.postid = post.post.id;
            instance = this;
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            string commentText = commenttxtbox.Text;
            commenttxtbox.Text = string.Empty;
            Comment newCom = new Comment(Username, postid, commentText);
            MessageBox.Show(post.post.NumberOfComments.ToString());
            newCom.Insert(newCom);

            //Create a new instance of PostControl and pass the necessary information
            CommentControl ComControl = new CommentControl(newCom, user);
            post.post.RefreshNumberOfLikesComments();
            post.labelcmnt.Text = post.post.NumberOfComments.ToString();

            // Add the PostControl to the PostsContainer in FormApp
            flowLayoutPanel2.Controls.Add(ComControl);
        }

        public static List<Comment> GetAllComments(int pID)
        {
            List<Comment> allComments = new List<Comment>();

            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                string sql = "SELECT id, Username, CommentText, postID, timeStamp FROM commentstable WHERE postID = @pID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pID", pID);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Username = reader["Username"].ToString();
                        int id = Convert.ToInt32(reader["id"]);
                        string CommentText = reader["CommentText"].ToString();
                        int postID = Convert.ToInt32(reader["postID"]);
                        DateTime time = reader.GetDateTime("timeStamp");

                        Comment com = new Comment(Username, postID, CommentText, id, time);
                        allComments.Add(com);
                    }
                }
            }
            finally
            {
                // Ensure the connection is closed even in case of an exception
                conn.Close();
            }

            return allComments ;
        }
        private void FormComment_Load(object sender, EventArgs e)
        {
            List<Comment> comlist = GetAllComments(this.post.post.id);
            for (int i = comlist.Count - 1; i >= 0; i--)
            {
                Comment com = comlist[i];
                CommentControl comControl = new CommentControl(com, user);
                comControl.DeleteButtonVisibility();
                flowLayoutPanel2.Controls.Add(comControl);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            post.post.RefreshNumberOfLikesComments();
            post.labelcmnt.Text = post.post.NumberOfComments.ToString();
        }
        public void CloseForm()
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
