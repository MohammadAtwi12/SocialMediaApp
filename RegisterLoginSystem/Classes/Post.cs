using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegisterLoginSystem.Classes
{
    public class Post
    {
        public string Username { get; set; }
        public string postText { get; set; }
        public int NumberOfLikes { get; set; } = 0;
        public int NumberOfComments { get; set; } = 0;
        public List<byte[]> Images { get; set; }
        public int id { get; set; }
        public DateTime TimeStamp { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public Post(User user, string text, List<byte[]> images)
        {
            Username = user.Username;
            postText = text;
            Images = images;
            TimeStamp = DateTime.Now;
        }
        public Post(string username, string text, int id, DateTime time) {
            this.Username = username;
            this.postText = text;
            this.id = id;
            TimeStamp = time;
        }


        public bool Insert(Post c)
        {
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO poststable (username, postText, images, numberOfLikes,numberOfComments, timeStamp) VALUES (@username, @postText, @images, @numberOfLikes,@numberOfComments, @timeStamp); SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", c.Username);
                cmd.Parameters.AddWithValue("@postText", c.postText);
                cmd.Parameters.AddWithValue("@numberOfLikes", c.NumberOfLikes);
                cmd.Parameters.AddWithValue("@numberOfComments", c.NumberOfComments);
                cmd.Parameters.AddWithValue("@timeStamp", c.TimeStamp);
                byte[] combinedImages = CombineImages(c.Images);
                cmd.Parameters.AddWithValue("@images", combinedImages);
                conn.Open();
                int insertedId = Convert.ToInt32(cmd.ExecuteScalar());

                if (insertedId > 0)
                {
                    c.id = insertedId;
                    isSuccess = true;
                    //System.Windows.Forms.MessageBox.Show(c.id.ToString());
                    //System.Windows.Forms.MessageBox.Show("Posted successfully!");
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        public bool Delete(Post c)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM poststable WHERE id = @id; DELETE FROM commentstable WHERE postID = @id; DELETE FROM likestable WHERE postID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else { isSuccess = false; }


            }
            catch (Exception sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool AddLike(Post c, string lUsername)
        {
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                bool isLiked = true;
                string sql = "UPDATE poststable SET numberOfLikes = numberOfLikes + 1 WHERE id = @postID; INSERT INTO likestable (postID, username, isLiked) VALUES (@postID, @username, @isLiked)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@postID", c.id);
                cmd.Parameters.AddWithValue("@username", lUsername);
                cmd.Parameters.AddWithValue("@isLiked", isLiked);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                    c.RefreshNumberOfLikesComments();  // Update the NumberOfLikes property
                }
            }
            catch (Exception sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool DeleteLike(Post c, string lUsername)
        {
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE poststable SET numberOfLikes = numberOfLikes - 1 WHERE id = @id; DELETE FROM likestable WHERE postID = @id AND username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@username", lUsername);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                    c.RefreshNumberOfLikesComments();  // Update the NumberOfLikes property
                }
            }
            catch (Exception sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public void RefreshNumberOfLikesComments()
        {
            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "SELECT numberOfLikes, numberOfComments FROM poststable WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    NumberOfLikes = Convert.ToInt32(dr[0]);
                    NumberOfComments = Convert.ToInt32(dr[1]);
                }
            }
            catch (Exception sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool isLiked(Post c, string lUsername)
        {
            bool isLiked = false;
            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "SELECT isLiked FROM likestable WHERE username = @Username AND postID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@username", lUsername);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    isLiked = Convert.ToBoolean(result);
                }
            }
            catch (Exception sqlException)
            {
                MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isLiked;

        }

        private byte[] CombineImages(List<byte[]> images)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                foreach (byte[] image in images)
                {
                    // Write the length of the current image as a 4-byte integer
                    byte[] lengthBytes = BitConverter.GetBytes(image.Length);
                    ms.Write(lengthBytes, 0, lengthBytes.Length);

                    // Write the actual image data
                    ms.Write(image, 0, image.Length);
                }
                return ms.ToArray();
            }
        }

    }

}
