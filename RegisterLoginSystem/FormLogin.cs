using RegisterLoginSystem.Classes;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterLoginSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            txtPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        User c = new User();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public void Clear()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBoxShowPass.Checked ? '\0' : '*';
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void backRegisterLbl_Click(object sender, EventArgs e)
        {
            // Hide the current form
            this.Hide();

            // Show the Register form
            new frmRegister().Show();
            

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            c.Username = txtUsername.Text;
            c.SetPassword(txtPassword.Text);
            c.ProfileImage = c.GetProfileImageFromDatabase(c);
            c.Info = c.GetInfoFromDatabase(c);
            c.FullName = c.GetNameFromDatabase(c);
            bool success = c.Login(c);
            if (success)
            {
                MessageBox.Show("Loged In Successfully");
                ToApp();
                
                Clear();
            }
            else
            {
                MessageBox.Show("Failed, Please Check Your Username or Password");
            }

        }

        private void ToApp()
        {
            new FormApp(c).Show();
            this.Hide();
        }
    }
}
