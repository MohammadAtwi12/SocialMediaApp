using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterLoginSystem.Classes
{
    public class Comment
    {
        public string Username { get; set; }
        public string CommentText { get; set; }
        public int PostCommentedOnID { get; set; }
        public DateTime timeStamp { get; set; }

        public int id { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public Comment(string username,int postId, string Text)
        {
            Username = username;
            CommentText = Text;
            PostCommentedOnID = postId;
            timeStamp = DateTime.Now;
        }

        public Comment(string Username, int postId, string Text, int id, DateTime time) 
        {
            this.Username = Username;
            CommentText = Text;
            PostCommentedOnID = postId;
            this.id = id;
        }

        public bool Insert(Comment c)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO commentstable (username, CommentText, postID, timeStamp) VALUES (@username, @CommentText, @postID, @timeStamp); SELECT LAST_INSERT_ID(); UPDATE poststable SET numberOfComments = numberOfComments + 1 WHERE id = @postID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", c.Username);
                cmd.Parameters.AddWithValue("@CommentText", c.CommentText);
                cmd.Parameters.AddWithValue("@postID", c.PostCommentedOnID);
                cmd.Parameters.AddWithValue("@timeStamp", c.timeStamp);
                conn.Open();
                int insertedId = Convert.ToInt32(cmd.ExecuteScalar());

                if (insertedId > 0)
                {
                    c.id = insertedId;
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
       
        public bool Delete(Comment c)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM commentstable WHERE id = @id; UPDATE poststable SET numberOfComments = numberOfComments - 1 WHERE id = @postID;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", c.id);
                cmd.Parameters.AddWithValue("@postID",c.PostCommentedOnID);
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
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
