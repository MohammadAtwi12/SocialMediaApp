using Google.Protobuf.WellKnownTypes;
using RegisterLoginSystem.Classes;
using RegisterLoginSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    public partial class FriendControl : UserControl
    {
        public User user;
        public string senderUsername;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public Button rejectButton;
        public Button accept_remove_Button;
        public Label namelbl;
        public Label label;
        public FriendControl(User user, string senderUsername)
        {
            InitializeComponent();
            this.user = user;
            this.senderUsername = senderUsername;
            userenameLabel.Text = senderUsername;
            SetProfileImage(senderUsername);
            rejectButton = buttonreject;
            namelbl = labelname;
            accept_remove_Button = buttonAdd_Accept_remove;
            label = label2;
        }

        public void SetProfileImage(string username)
        {
            byte[] profileImageArr = null;

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
                                profileImageArr = (byte[])reader["profileImg"];
                                if (profileImageArr != null && profileImageArr.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(profileImageArr))
                                    {
                                        Image image = Image.FromStream(ms);
                                        pictureBoxprof.Image = image;
                                    }
                                }
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
        }

        private void buttonreject_Click(object sender, EventArgs e)
        {
            user.RemoveFriend(user, senderUsername);
            this.Dispose();
        }

        private void buttonAdd_Accept_remove_Click(object sender, EventArgs e)
        {
            if (user.GetFriendshipStatus(user, senderUsername) == "pending")
            {
                if (FormApp.instance != null)
                {
                    user.RemoveFriend(user, senderUsername);
                    accept_remove_Button.BackgroundImage = Resources.add_friend;
                }
                else
                {
                    user.AcceptReq(user, senderUsername);
                    FriendControl friend = new FriendControl(user, senderUsername);
                    friend.rejectButton.Visible = false;
                    friend.accept_remove_Button.BackgroundImage = Resources.remove_user;
                    FormProfile.instance.friendsContainer.Controls.Add(friend);
                    this.Dispose();
                }
                
            }
            else
            {
                if (FormApp.instance != null)
                {
                    user.SendReq(user, senderUsername);
                    accept_remove_Button.BackgroundImage = Resources.decline;
                }
                else
                {
                    user.RemoveFriend(user, senderUsername);
                    this.Dispose();
                }
                
            }
        }

        private void userenameLabel_Click(object sender, EventArgs e)
        {
            if (FormProfile.instance == null)
            {
                new FormProfile(user, userenameLabel.Text).Show();
                FormApp.instance.Dispose();
            }
            else if (FormProfile.instance != null)
            {
                FormProfile.instance.Dispose();
                new FormProfile(user, userenameLabel.Text).Show();
            }
        }
    }
}

