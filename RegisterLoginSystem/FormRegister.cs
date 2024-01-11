using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegisterLoginSystem.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.IO;
using MySql.Data.MySqlClient;

namespace RegisterLoginSystem
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            txtPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        User c = new User();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            c.Username = txtUsername.Text;
            c.FullName = textBoxFullname.Text;
            c.SetPassword(txtPassword.Text);
            c.ProfileImage = ImageToByteArray(Properties.Resources.DefaultProfile);
            c.Info = "No Info";


            if (UsernameExists(c.Username))
            {
                MessageBox.Show("Username already taken. Please choose a different username.");
            }
            else
            {
                if ((txtConfirmPassword.Text == "") || (txtConfirmPassword.Text != txtPassword.Text) || (textBoxFullname.Text == ""))
                {
                    MessageBox.Show("Wrong Password, Please Try Again");
                }
                else
                { 
                    // Perform the insertion if the username is not found
                    bool success = c.Insert(c);
                    if (success)
                    {
                        MessageBox.Show("New Account Inserted Successfully");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed, Please Try Again");
                    }
                }                
            }
        }

        public void Clear()
        {
            txtConfirmPassword.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            textBoxFullname.Text = string.Empty;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public bool UsernameExists(string username)
        {
            MySqlConnection connection = new MySqlConnection(myconnstring);

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT 1 FROM accountstable WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                return command.ExecuteScalar() != null;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                connection.Dispose();
            }
        }

        private void backLoginLbl_Click(object sender, EventArgs e)
        {
            // Close the current registration form
            this.Hide();

            // Show the Login form
            new FormLogin().Show();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
            txtConfirmPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
