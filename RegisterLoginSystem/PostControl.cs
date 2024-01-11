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

namespace RegisterLoginSystem
{
    public partial class PostControl : UserControl
    {

        private int currentIndex = -1;
        private List<byte[]> images;
        public Post post;
        public User user;
        public Label labelcmnt;
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public PostControl(Post post , User user)
        {
            InitializeComponent();
            this.user = user;
            this.post = post;
            images = post.Images;
            posttxtLabel.Text = post.postText;
            labelnolikes.Text = post.NumberOfLikes.ToString();
            labelcomments.Text = post.NumberOfComments.ToString();
            usrnameLabel.Text = post.Username;
            labeltime.Text = post.TimeStamp.ToString();
            labelcmnt = labelcomments;

            // Display the first image in the list
            if (images.Count >= 0)
            {
                ShowImageAtIndex(0);
            } 

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
                    int maxWidth = PostpictureBox.Width;
                    int maxHeight = PostpictureBox.Height;

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
                    PostpictureBox.Image = resizedImage;

                    PostpictureBox.BackgroundImage = null;

                    // Update the current index
                    currentIndex = index;

                    // Update button visibility
                    UpdateButtonVisibility();
                }
            }
            else
            {
                PostpictureBox.Hide();
                currentIndex = -1;
                UpdateButtonVisibility();
            }
        }

        public void DeleteButtonVisibility()
        {
            if(this.user.Username != this.post.Username)
            {
                buttonDelete.Visible = false;
            }
            else
            {
                buttonDelete.Visible = true;
            }
        }

        private void UpdateButtonVisibility()
        {
            // Show or hide buttons based on the number of images
            previousButton.Visible = currentIndex > 0;
            nextButton.Visible = currentIndex < images.Count - 1;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                // Show the previous image
                ShowImageAtIndex(currentIndex - 1);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < images.Count - 1)
            {
                // Show the next image
                ShowImageAtIndex(currentIndex + 1);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.post.Delete(post);
            this.Dispose();
        }

        private void AdjustPictureBoxLocation()
        {
            // Set the location and size of the Label
            posttxtLabel.Location = new System.Drawing.Point(46, 50);  // Adjust the Y-coordinate as needed
            posttxtLabel.AutoSize = false;
            posttxtLabel.MaximumSize = new System.Drawing.Size(320, int.MaxValue); // Set your maximum width

            // Calculate the new Y-coordinate for the PictureBox below the Label with a space of 20 units
            int newYValue = posttxtLabel.Bottom + 20;
            this.PostpictureBox.Location = new System.Drawing.Point(this.PostpictureBox.Location.X, newYValue);
            this.previousButton.Location = new System.Drawing.Point(this.previousButton.Location.X, newYValue+80);
            this.nextButton.Location = new System.Drawing.Point(this.nextButton.Location.X, newYValue+80);
            int newYv2 = PostpictureBox.Bottom + 15;
            this.commentButton.Location = new System.Drawing.Point(this.commentButton.Location.X, newYv2);
            this.likeButton.Location = new System.Drawing.Point(this.likeButton.Location.X, newYv2);
            this.labelnolikes.Location = new System.Drawing.Point(this.labelnolikes.Location.X, newYv2+10);
            this.labelcomments.Location = new System.Drawing.Point(this.labelcomments.Location.X, newYv2 + 10);
        }

        private void AdjustInteractsLocation()
        {
            int newYValue = posttxtLabel.Bottom + 20;
            if (this.post.Images.Count <= 0 ) 
            {
                this.commentButton.Location = new System.Drawing.Point(this.commentButton.Location.X, newYValue);
                this.likeButton.Location = new System.Drawing.Point(this.likeButton.Location.X, newYValue);
                this.labelnolikes.Location = new System.Drawing.Point(this.labelnolikes.Location.X, newYValue+10);
                this.labelcomments.Location = new System.Drawing.Point(this.labelcomments.Location.X, newYValue + 10);
            }
        }

        private void posttxtLabel_SizeChanged(object sender, EventArgs e)
        {
            AdjustPictureBoxLocation();
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isLiked = post.isLiked(post, user.Username);

                if (isLiked)
                {
                    likeButton.BackgroundImage = Properties.Resources.love;
                    post.DeleteLike(post, user.Username);                    
                }
                else
                {
                    likeButton.BackgroundImage = Properties.Resources.heart;
                    post.AddLike(post, user.Username);
                }

                // Refresh the number of likes and update UI
                post.RefreshNumberOfLikesComments();
                labelnolikes.Text = post.NumberOfLikes.ToString();
                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            new FormComment(user, this).ShowDialog();
        }

        private void PostControl_Load(object sender, EventArgs e)
        {
            if (post.isLiked(post, user.Username) == true )
            {
                likeButton.BackgroundImage = Properties.Resources.heart;               
            }
            else
            {
                likeButton.BackgroundImage = Properties.Resources.love;
            }
            AdjustInteractsLocation();
            post.RefreshNumberOfLikesComments();
            labelnolikes.Text=post.NumberOfLikes.ToString();
            labelcomments.Text=post.NumberOfComments.ToString();
            setPicBox();
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
            if (post.Username == user.Username)
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
                byte[] profileImageFromDatabase = GetProfileImageFromDatabase(post.Username);

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

        private void usrnameLabel_Click(object sender, EventArgs e)
        {
            if(FormProfile.instance == null)
            {
                new FormProfile(user, usrnameLabel.Text).Show();
                FormApp.instance.Dispose();
            }
        }

        private void labelcomments_Click(object sender, EventArgs e)
        {

        }
    }
}
