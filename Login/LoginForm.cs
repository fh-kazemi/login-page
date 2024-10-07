using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txt_Password.UseSystemPasswordChar = true;
            btn_HidePassword.BringToFront();
        }
        
        private void btn_RegisterForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(); 
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Username.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Username, "Username is required!");
                txt_Username.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Password, "Password is required!");
                txt_Password.Focus();
            }
            else {
                User user = new User();
                user.Username = txt_Username.Text.Trim().ToLower();
                                
                string connectionString = "Data Source=***;Initial Catalog=***;user=admin;password=admin;TrustServerCertificate=True";
                SqlConnection connection = new SqlConnection(connectionString);

                string query = $"SELECT * FROM tblusers WHERE username= @Username";

                SqlCommand cmd = new SqlCommand(query,connection);
                cmd.Parameters.AddWithValue("@Username", user.Username);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                bool isExist = false;
                if (reader.Read())
                {
                    isExist = true;
                    user.Id = reader.GetString(0);
                    user.Firstname = reader.GetString(1);
                    user.Lastname = reader.GetString(2);
                    user.Email = reader.GetString(3);
                    user.Username = reader.GetString(4);
                    user.Password = reader.GetString(5);
                }
                if (isExist.Equals(true) && Cryptography.Decrypt(user.Password).Equals(txt_Password.Text.Trim()))
                {
                    this.Hide();
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    homePage.GetUserData(user);
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!\nTry again...");
                    txt_Username.Text = "";
                    txt_Password.Text = "";
                }               

                connection.Close();
            }
        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            btn_HidePassword.BringToFront();
        }

        private void btn_HidePassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            btn_ShowPassword.BringToFront();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
