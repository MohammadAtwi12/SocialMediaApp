using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace RegisterLoginSystem.Classes
{
    public class User
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public byte[] ProfileImage { get; set; }
        public string Info { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public void SetPassword(string newPassword)
        {
            Password = newPassword;
        }

        public bool Insert(User c)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO accountstable (Username, Password, profileImg, info, fullname) VALUES (@Username, @Password, @img, @info, @fullname)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", c.Username);
                cmd.Parameters.AddWithValue("@Password", c.Password);
                cmd.Parameters.AddWithValue("@img", c.ProfileImage);
                cmd.Parameters.AddWithValue("@info", c.Info);
                cmd.Parameters.AddWithValue("@fullname", c.FullName);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else { isSuccess = false; }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Login(User c)
        {
            MySqlConnection connection = new MySqlConnection(myconnstring);

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT 1 FROM accountstable WHERE Username = @Username AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Username", c.Username);
                command.Parameters.AddWithValue("@Password", c.Password);

                // Execute the query and check if a matching record is found
                return command.ExecuteScalar() != null;
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, display an error message, etc.)
                Console.WriteLine($"Error during login: {ex.Message}");
                return false;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

                // Explicitly disposing the connection
                connection.Dispose();
            }
        }
        
        public bool ChangeProfile(User c)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE accountstable SET profileImg = @ProfileImage WHERE username = @Username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", c.Username);
                cmd.Parameters.AddWithValue("@ProfileImage", c.ProfileImage);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else { isSuccess = false; }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        
        public bool ChangeInfo(User c)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE accountstable SET info = @info WHERE username = @Username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", c.Username);
                cmd.Parameters.AddWithValue("@info", c.Info);
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else { isSuccess = false; }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool SendReq(User c, string r)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO friendstable (sender, receiver, status) VALUES (@sender, @receiver, @status)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sender", c.Username);
                cmd.Parameters.AddWithValue("@receiver", r);
                cmd.Parameters.AddWithValue("@status", "pending");
                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else { isSuccess = false; }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool AcceptReq(User c, string r)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE friendstable SET status = 'friends' WHERE sender = @sender AND receiver = @receiver";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sender", r); // Sender becomes the receiver in this case
                cmd.Parameters.AddWithValue("@receiver", c.Username); // Receiver becomes the sender in this case

                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool RemoveFriend(User c, string r)
        {
            bool isSuccess = false;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM friendstable WHERE (sender = @sender AND receiver = @receiver) OR (sender = @receiver AND receiver = @sender)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sender", r); // Sender becomes the receiver in this case
                cmd.Parameters.AddWithValue("@receiver", c.Username); // Receiver becomes the sender in this case

                conn.Open();
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public string GetFriendshipStatus(User c, string r)
        {
            string status = null;

            MySqlConnection conn = new MySqlConnection(myconnstring);
            try
            {
                string sql = "SELECT status FROM friendstable WHERE (sender = @user1 AND receiver = @user2) OR (sender = @user2 AND receiver = @user1)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user1", c.Username);
                cmd.Parameters.AddWithValue("@user2", r);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    status = reader["status"].ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;
        }

        public byte[] GetProfileImageFromDatabase(User c)
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
                        cmd.Parameters.AddWithValue("@username", c.Username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                profileImage = (byte[])reader["profileImg"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return profileImage;
        }

        public string GetInfoFromDatabase(User c)
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
                        cmd.Parameters.AddWithValue("@username", c.Username);

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

        public string GetNameFromDatabase(User c)
        {
            string fullname = string.Empty;

            using (MySqlConnection conn = new MySqlConnection(myconnstring))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT fullname FROM accountstable WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", c.Username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming "profilImg" is the column name in the accounts table
                                fullname = (string)reader["fullname"];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (logging, displaying an error message, etc.)
                    Console.WriteLine("" + ex.Message);
                }
            }

            return fullname;
        }

    }
}
