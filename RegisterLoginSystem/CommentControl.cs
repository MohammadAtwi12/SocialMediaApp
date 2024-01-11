using RegisterLoginSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    public partial class CommentControl : UserControl
    {
        public User user { get; set; }
        public Comment comment { get; set; }
        public CommentControl(Comment comment, User user)
        {
            InitializeComponent();
            this.comment = comment;
            this.user = user;
            userenameLabel.Text = comment.Username;
            commenttxtLabel.Text = comment.CommentText;
            labeltime.Text = comment.timeStamp.ToString();
        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void buttonDeleteCom_Click(object sender, EventArgs e)
        {
            this.comment.Delete(comment);
            this.Dispose();
        }

        public void DeleteButtonVisibility()
        {
            if (this.user.Username != this.comment.Username)
            {
                buttonDeleteCom.Visible = false;
            }
            else
            {
                buttonDeleteCom.Visible = true;
            }
        }

        private void userenameLabel_Click(object sender, EventArgs e)
        {
            if (FormProfile.instance == null)
            {
                new FormProfile(user, userenameLabel.Text).Show();
                FormApp.instance.Dispose();
                FormComment.instance.Dispose();
            }
            else if (FormProfile.instance.user.Username != userenameLabel.Text)
            {
                FormProfile.instance.Dispose();
                FormProfile.instance = null;
                new FormProfile(user, userenameLabel.Text).Show();
                FormComment.instance.Dispose();
                FormComment.instance = null;
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

        public void setPicBox()
        {
            if (comment.Username == user.Username)
            {
                if (user.ProfileImage != null && user.ProfileImage.Count() > 0)
                {
                    using (MemoryStream ms = new MemoryStream(user.ProfileImage.ToArray()))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBoxprof.Image = image;
                    }
                }
            }
            else
            {
                byte[] profileImageFromDatabase = GetProfileImageFromDatabase(comment.Username);

                if (profileImageFromDatabase != null && profileImageFromDatabase.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(profileImageFromDatabase))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBoxprof.Image = image;
                    }
                }
            }
        }

        private void CommentControl_Load(object sender, EventArgs e)
        {
            setPicBox();
        }
    }
}
