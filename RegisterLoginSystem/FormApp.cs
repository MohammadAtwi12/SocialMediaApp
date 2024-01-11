using RegisterLoginSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FuzzySharp;
using FuzzySharp.SimilarityRatio;
using RegisterLoginSystem.Properties;

namespace RegisterLoginSystem
{
    public partial class FormApp : Form
    {
        public static FormApp instance;
        public FlowLayoutPanel postsContainer;
        public User user;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public FormApp(User c)
        {
            InitializeComponent();
            instance = this;
            postsContainer = flowLayoutPanel1;
            user = c;
            flowLayoutPanesu.Visible = false;
        }

        private void crtPostbtn_Click(object sender, EventArgs e)
        {
            new FormPost(user).ShowDialog();
        }

        private void FormApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public List<Post> GetAllPosts()
        {
            List<Post> allPosts = new List<Post>();

            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                string sql = "SELECT id, username, postText, images, timeStamp FROM poststable";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Username = reader["username"].ToString();
                        int id = Convert.ToInt32(reader["id"]);
                        string postText = reader["postText"].ToString();
                        byte[] combinedImages = (byte[])reader["images"];
                        DateTime time = reader.GetDateTime("timeStamp");

                        // Convert combined images to a list of byte arrays
                        List<byte[]> imagesList = SplitCombinedImages(combinedImages);

                        Post post = new Post(Username, postText, id, time);
                        post.Images = imagesList;
                        allPosts.Add(post);    
                    }
                }
            }
            finally
            {
                // Ensure the connection is closed even in case of an exception
                conn.Close();
            }

            return allPosts;
        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            setpicbox();
            setSuggestions();
            usrnameLabel.Text = user.Username;
            List<Post> posts = GetAllPosts();

            for (int i = posts.Count - 1; i >= 0; i--)
            {
                Post post = posts[i];
                PostControl postControl = new PostControl(post, user);
                postControl.DeleteButtonVisibility();
                postsContainer.Controls.Add(postControl);
            }

        }

        private static List<byte[]> SplitCombinedImages(byte[] combinedImages)
        {
            List<byte[]> imagesList = new List<byte[]>();
            int index = 0;

            while (index < combinedImages.Length)
            {
                // Ensure there are enough bytes to read the length
                if (index + sizeof(int) > combinedImages.Length)
                {
                    throw new ArgumentException("Invalid combined image format.");
                }

                int length = BitConverter.ToInt32(combinedImages, index);
                index += sizeof(int);

                // Check if there are enough bytes to read the image data
                if (index + length > combinedImages.Length)
                {
                    throw new ArgumentException("Invalid combined image format.");
                }

                byte[] image = new byte[length];
                Buffer.BlockCopy(combinedImages, index, image, 0, length);
                index += length;

                imagesList.Add(image);
            }

            return imagesList;
        }

        private void buttonprofile_Click(object sender, EventArgs e)
        {
            new FormProfile(user, user.Username).Show();
            instance = null;
            this.Dispose();
        }

        private void setpicbox()
        {
            if (user.ProfileImage != null && user.ProfileImage.Count() > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.ProfileImage.ToArray()))
                {
                    Image image = Image.FromStream(ms);
                    pictureBox1.Image = image;
                }
            }
            infolbl.Text = user.Info;
        }

        private void setSuggestions()
        {
            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                string sql = "SELECT Username, FullName, info FROM accountstable";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Username = reader["Username"].ToString();
                        string FullName = reader["FullName"].ToString();
                        string Info = reader["info"].ToString();
                        if((AreStringsSimilar(user.Username, Username, 40) || AreStringsSimilar(user.FullName, FullName, 40) || (AreStringsSimilar(user.Info, Info, 40) && Info != "No Info")) && user.Username != Username && user.GetFriendshipStatus(user, Username)!= "friends")
                        {
                            string status = user.GetFriendshipStatus(user, Username);
                            if (status != string.Empty)
                            {
                                FriendControl sugFriend = new FriendControl(user, Username);
                                sugFriend.rejectButton.Visible = false;
                                sugFriend.accept_remove_Button.BackgroundImage = Resources.add_friend;
                                flowLayoutPanelSuggestions.Controls.Add(sugFriend);
                            }
                            else if (status == "pending") 
                            {
                                FriendControl sugFriend = new FriendControl(user, Username);
                                sugFriend.rejectButton.Visible = false;
                                sugFriend.accept_remove_Button.BackgroundImage = Resources.decline;
                                flowLayoutPanelSuggestions.Controls.Add(sugFriend);
                            }                           
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private bool AreStringsSimilar(string str1, string str2, int threshold)
        {
            if(str1 == null || str2 == null)
            {
                MessageBox.Show("strings Null" + str1 + str2);
                return false;
            }
            int similarity = Fuzz.Ratio(str1, str2);
            return similarity >= threshold;
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            instance = null;
            Dispose();
            new FormLogin().Show();

        }

        private void pictureBoxlogout_Click(object sender, EventArgs e)
        {
            instance = null;
            Dispose();
            new FormLogin().Show();
        }

        private List<FriendControl> Search(string key)
        {
            List<FriendControl> list = new List<FriendControl>();
            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                conn.Open();
                string sql = "SELECT Username, fullname FROM socialmediaapp.accountstable";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                        list.Clear();
                    
                        while (reader.Read())
                        {
                            string Username = reader["Username"].ToString();
                            string fullname = reader["fullname"].ToString();
                            if(AreStringsSimilar(Username, key, 50) || AreStringsSimilar(fullname, key, 50))
                            {
                                FriendControl su = new FriendControl(user, Username);
                                su.namelbl.Text = fullname;
                                su.namelbl.Visible = true;
                                su.accept_remove_Button.Visible = false;
                                su.rejectButton.Visible = false;
                                su.Width = 435;
                                su.label.Text = "_______________________________________________________________________";
                                list.Add(su);
                                flowLayoutPanesu.Controls.Add(su);
                            }
                            
                        }
                                    
                }
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanesu.Visible = true;
            string keyword = textBoxsearch.Text;
            flowLayoutPanesu.Controls.Clear();
            List<FriendControl> list = Search(keyword);
            if(textBoxsearch.Text==string.Empty)
            {
                flowLayoutPanesu.Visible = false;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
      
            
        }
    }
}
