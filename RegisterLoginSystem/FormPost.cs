using RegisterLoginSystem.Classes;
using RegisterLoginSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    public partial class FormPost : Form
    {
        public static FormPost instance;

        private List<string> imagePaths = new List<string>();
        private List<byte[]> images = new List<byte[]>();
        private int currentIndex = -1;
        public User user;

        public FormPost(User c)
        {
            InitializeComponent();
            instance = this;
            user = c;
        }

        private List<byte[]> ConvertImagePathsToImages(List<string> paths)
        {
            List<byte[]> imageList = new List<byte[]>();

            foreach (string imagePath in paths)
            {
                byte[] imageData = File.ReadAllBytes(imagePath);
                imageList.Add(imageData);
            }

            return imageList;
        }

        private void FormPost_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string imagePath in files)
            {
                // Add each image path to the list
                imagePaths.Add(imagePath);
            }
            images = ConvertImagePathsToImages(imagePaths);

            // Display the first image in the list
            ShowImageAtIndex(0);

            // Update button visibility
            UpdateButtonVisibility();
        }

        private void ShowImageAtIndex(int index)
        {
            if (images.Count > 0 && index >= 0 && index < images.Count)
            {
                // Load the image from the byte array
                using (MemoryStream ms = new MemoryStream(images[index]))
                {
                    Image image = Image.FromStream(ms);

                    // Resize the image to fit within the PictureBox
                    int maxWidth = pictureBox1.Width;
                    int maxHeight = pictureBox1.Height;

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
                    pictureBox1.Image = resizedImage;

                    pictureBox1.BackgroundImage = null;

                    // Update the current index
                    currentIndex = index;

                    // Update button visibility
                    UpdateButtonVisibility();
                }
            }
            else
            {
                // Clear the PictureBox and hide the next and previous buttons if no images
                pictureBox1.Image = null;
                pictureBox1.BackgroundImage = Properties.Resources.imgbg;
                currentIndex = -1;
                UpdateButtonVisibility();
            }
        }

        private void UpdateButtonVisibility()
        {
            // Show or hide buttons based on the number of images
            previousButton.Visible = currentIndex > 0;
            nextButton.Visible = currentIndex < images.Count - 1;
        }

        private void FormPost_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            if (currentIndex < images.Count - 1)
            {
                // Show the next image
                ShowImageAtIndex(currentIndex + 1);
            }
        }

        private void previousButton_Click_1(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                // Show the previous image
                ShowImageAtIndex(currentIndex - 1);
            }
        }

        private void buttonAddImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Clear existing images before adding new ones
                imagePaths.Clear();

                // Get all selected file paths
                foreach (string imagePath in openFileDialog1.FileNames)
                {
                    imagePaths.Add(imagePath);
                }
                images=ConvertImagePathsToImages(imagePaths);

                // Display the first image in the list
                ShowImageAtIndex(0);

                // Update button visibility
                UpdateButtonVisibility();
            }
        }

        private void buttonDeleteImg_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                // Remove the image path from the list
                imagePaths.RemoveAt(currentIndex);

                // Show the next image (if available) or clear the PictureBox
                ShowImageAtIndex(currentIndex);

                // Update button visibility
                UpdateButtonVisibility();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            imagePaths.Clear();

            // Clear the PictureBox
            pictureBox1.Image = null;

            pictureBox1.BackgroundImage = Properties.Resources.imgbg;

            // Clear the TextBox
            txtPost.Clear();

            // Update button visibility
            UpdateButtonVisibility();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string postText = txtPost.Text;
            Post newPost = new Post(user, postText, images);
            newPost.Insert(newPost);

            // Add the PostControl to the PostsContainer in FormApp
            if (FormApp.instance != null && !FormApp.instance.IsDisposed) 
            { 
                FormApp.instance.postsContainer.Controls.Clear();
                List<Post> posts = FormApp.instance.GetAllPosts();

                for (int i = posts.Count - 1; i >= 0; i--)
                {
                    Post post = posts[i];
                    PostControl postControl = new PostControl(post, user);
                    postControl.DeleteButtonVisibility();
                    FormApp.instance.postsContainer.Controls.Add(postControl);
                }
            }
            if (FormProfile.instance != null && !FormProfile.instance.IsDisposed)
            {
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

            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
