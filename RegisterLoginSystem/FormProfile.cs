using RegisterLoginSystem.Classes;
using RegisterLoginSystem.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace RegisterLoginSystem
{
    public partial class FormProfile : Form
    {
        public static FormProfile instance;
        public FlowLayoutPanel postsContainer;
        public FlowLayoutPanel friendsContainer;
        public PictureBox profilePicBox;
        public Label infoLabel;
        public User user;
        public string profUsername;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public FormProfile(User c , string profUsername)
        {
            InitializeComponent();
            instance = this;
            postsContainer = flowLayoutPanel1;
            friendsContainer = flowLayoutPanelfriends;
            profilePicBox = pictureBox1;
            infoLabel = infolbl;
            usrnameLabel.Text = profUsername;
            this.user = c;           
            this.profUsername = profUsername;
        }

        private void FormProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public List<Post> GetAllPosts()
        {
            List<Post> allPosts = new List<Post>();

            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                string sql = "SELECT id, username, postText, images, timeStamp FROM poststable WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username",profUsername);
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

        private void ButtonVisibility()
        {
            if (profUsername != user.Username)
            {
                crtPostbtn.Visible = false;
                buttoninfoChange.Visible = false;
                buttonAddFr.Visible = true;
                label1.Visible = false;  
                flowLayoutPanelrequests.Visible = false;
                if(user.GetFriendshipStatus(user,profUsername) == "pending")
                {
                    buttonAddFr.Text = "Cancel Request";
                }
                else if (user.GetFriendshipStatus(user, profUsername) == "friends")
                {
                    buttonAddFr.Visible = false;
                }
            }
            else
            {
                crtPostbtn.Visible = true;//here add later to check if there is an already sent request
                buttoninfoChange.Visible = true;
                buttonAddFr.Visible = false;
                label1.Visible = true;
                flowLayoutPanelrequests.Visible = true;
            }
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            ButtonVisibility();
            setPicBox();
            if(user.Username == profUsername)
            {
                SetAllFriends();
                SetAllRequests();
            }
            else
            {
                SetAllFriends();
            }
            
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

        private void crtPostbtn_Click(object sender, EventArgs e)
        {
            new FormPost(user).ShowDialog();
        }

        private void buttonfeed_Click(object sender, EventArgs e)
        {
            new FormApp(user).Show();
            if (FormComment.instance != null)
            {
                FormComment.instance.Dispose();
                FormComment.instance = null;
            }
            this.Dispose();
            instance = null;
        }

        private void buttonInfoChange_Click(object sender, EventArgs e)
        {
            new FormInfo(user).ShowDialog();
        }

        public void setPicBox()
        {
            if(user.Username == profUsername)
            {
                if (user.ProfileImage != null && user.ProfileImage.Count() > 0)
                {
                    using (MemoryStream ms = new MemoryStream(user.ProfileImage.ToArray()))
                    {
                        Image image = Image.FromStream(ms);
                        profilePicBox.Image = image;
                    }
                }
                infoLabel.Text = user.Info;
            }
            else
            {
                byte[] profileImageFromDatabase = GetProfileImageFromDatabase(profUsername);

                if (profileImageFromDatabase != null && profileImageFromDatabase.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(profileImageFromDatabase))
                    {
                        Image image = Image.FromStream(ms);
                        profilePicBox.Image = image;
                    }
                }

                infoLabel.Text=GetInfoFromDatabase(profUsername);
            }
        }

        public byte[] GetProfileImageFromDatabase(string username)
        {
            byte[] profileImage = null;

            using (MySqlConnection conn = new MySqlConnection(myconnstring))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT profileImg FROM accountstable WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming "profilImg" is the column name in the accounts table
                                profileImage = (byte[])reader["profileImg"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (logging, displaying an error message, etc.)
                    Console.WriteLine("Error retrieving profile image from database: " + ex.Message);
                }
            }

            return profileImage;
        }

        public string GetInfoFromDatabase(string username)
        {
            string info = string.Empty;

            using (MySqlConnection conn = new MySqlConnection(myconnstring))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT info FROM accountstable WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming "profilImg" is the column name in the accounts table
                                info = (string)reader["info"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (logging, displaying an error message, etc.)
                    Console.WriteLine("Error retrieving profile image from database: " + ex.Message);
                }
            }

            return info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAddFr_Click(object sender, EventArgs e)
        {
            if (buttonAddFr.Text == "Add Friend")
            {
                user.SendReq(user, profUsername);
                buttonAddFr.Text = "Cancel Request";
            }
            else if (buttonAddFr.Text == "Cancel Request")
            {
                user.RemoveFriend(user, profUsername);
                buttonAddFr.Text = "Add Friend";
            }           
        }

        public void SetAllFriends()
        {
            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                string sql = "SELECT CASE WHEN sender = @profileUsername THEN receiver ELSE sender END AS friend_username FROM friendstable WHERE (sender = @profileUsername OR receiver = @profileUsername) AND status = 'friends'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@profileUsername", profUsername);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string friendUsername = reader["friend_username"].ToString();
                        FriendControl friend = new FriendControl(user, friendUsername);
                        friend.rejectButton.Visible = false;
                        friend.accept_remove_Button.BackgroundImage = Resources.remove_user;
                        if(user.Username != profUsername)
                        {
                            friend.accept_remove_Button.Visible = false;
                        }
                        flowLayoutPanelfriends.Controls.Add(friend);
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public void SetAllRequests()
        {
            MySqlConnection conn = new MySqlConnection(myconnstring);

            try
            {
                string sql = "SELECT sender FROM friendstable WHERE (receiver = @profileUsername) AND status = 'pending'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@profileUsername", profUsername);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string senderUsername = reader["sender"].ToString();
                        FriendControl friend = new FriendControl(user, senderUsername);
                        flowLayoutPanelrequests.Controls.Add(friend);
                    }
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
