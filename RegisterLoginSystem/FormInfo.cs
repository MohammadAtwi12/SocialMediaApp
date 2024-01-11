using RegisterLoginSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    public partial class FormInfo : Form
    {
        private string ProfileImagePath;
        private byte[] ProfileImage;
        public User user;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public FormInfo(User user)
        {
            InitializeComponent();
            this.user = user; 
        }

        private byte[] ConvertImagePathToImage(string path)
        {
            byte[] imageData = File.ReadAllBytes(path);
            return imageData;
        }

        private void FormInfo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Assuming only one file is dropped
                if (files.Length == 1)
                {
                    ProfileImagePath = files[0];
                    ProfileImage = ConvertImagePathToImage(ProfileImagePath);
                    pictureBoxProf.ImageLocation = ProfileImagePath;
                }
            }
            ShowImage(ProfileImage);
        }

        private void FormInfo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ShowImage(byte[] imageData)
        {
            if (imageData != null && imageData.Length > 0)
            {
                // Load the image from the byte array
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);

                    // Resize the image to fit within the PictureBox
                    int maxWidth = pictureBoxProf.Width;
                    int maxHeight = pictureBoxProf.Height;

                    int newWidth, newHeight;

                    if (image.Width > image.Height)
                    {
                        // Landscape image
                        newWidth = maxWidth;
                        newHeight = (int)((float)image.Height / image.Width * maxWidth);
                    }
                    else
                    {
                        // Portrait or square image
                        newWidth = (int)((float)image.Width / image.Height * maxHeight);
                        newHeight = maxHeight;
                    }

                    // Resize the image
                    Image resizedImage = new Bitmap(image, new Size(newWidth, newHeight));

                    // Set the PictureBox image
                    pictureBoxProf.Image = resizedImage;

                    pictureBoxProf.BackgroundImage = null;
                }
            }
            else
            {
                pictureBoxProf.Image = null;
            }
        }

        private void buttonAddImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Clear existing images before adding new ones
                ProfileImagePath = string.Empty;

                // Get the selected file path
                string imagePath = openFileDialog1.FileName;

                // Clear the existing list and add the new image path
                ProfileImagePath = imagePath;

                // Convert the image path to image data
                ProfileImage = ConvertImagePathToImage(ProfileImagePath);

                // Display the image
                ShowImage(ProfileImage);
            }
        }

        private void buttonDeleteImg_Click(object sender, EventArgs e)
        {
            ProfileImage = null;
            ProfileImagePath = string.Empty;
            // Show the next image (if available) or clear the PictureBox
            ShowImage(ProfileImage);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ProfileImagePath = string.Empty;

            // Clear the PictureBox
            pictureBoxProf.Image = null;

            pictureBoxProf.BackgroundImage = null;

            // Clear the TextBox
            txtAbout.Clear();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (ProfileImage != null && ProfileImage.Length > 0)
            {
                user.ProfileImage = ProfileImage;
                user.ChangeProfile(user);
                FormProfile.instance.setPicBox();
                FormProfile.instance.postsContainer.Controls.Clear();
                List<Post> posts = FormProfile.instance.GetAllPosts();

                for (int i = posts.Count - 1; i >= 0; i--)
                {
                    Post post = posts[i];
                    PostControl postControl = new PostControl(post, user);
                    postControl.DeleteButtonVisibility();
                    FormProfile.instance.postsContainer.Controls.Add(postControl);
                }
            }
            if (txtAbout.Text != string.Empty)
            {
                user.Info = txtAbout.Text;
                user.ChangeInfo(user);
                FormProfile.instance.infoLabel.Text = user.Info;
            }
            else
            {
                user.Info = "No Info";
                user.ChangeInfo(user);
                FormProfile.instance.infoLabel.Text = user.Info;
            }
            this.Close();
        }

        private void pictureBoxback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
