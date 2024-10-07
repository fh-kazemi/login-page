using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            txt_Password.UseSystemPasswordChar = true;
            txt_ConfirmPass.UseSystemPasswordChar = true;

            btn_HidePassword.BringToFront();
            btn_HideConfirmPass.BringToFront();
        }
        
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSSQL2017;Initial Catalog=RCDATA8_61458;user=SYSADM;password=SYSADM;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);

            User user = new User();

            bool validUserEmail = validEmail();
            bool validUuser = validUsername();
            bool validPass = validPassword();

            if (string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrWhiteSpace(txt_Email.Text) || !validUserEmail)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Email, "Email Address is required!");
                txt_Email.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Username.Text) || string.IsNullOrWhiteSpace(txt_Username.Text) || !validUuser)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Username, "Username is required!");
                txt_Username.Focus();
            }
            else if (string.IsNullOrEmpty(txt_Password.Text) || string.IsNullOrWhiteSpace(txt_Password.Text) || !validPass)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_Password, "Password is required!");
                txt_Password.Focus();
            }
            else if (string.IsNullOrEmpty(txt_ConfirmPass.Text) || string.IsNullOrWhiteSpace(txt_ConfirmPass.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ConfirmPass, "Confirm Password is required!");
                txt_Password.Focus();
            }
            else if (txt_ConfirmPass.Text != txt_Password.Text)
            {
                errorProvider.Clear();
                errorProvider.SetError(txt_ConfirmPass, "Password an Confirm password is not equal!\nRepeat again.");
                txt_ConfirmPass.Focus();
                txt_ConfirmPass.Text = "";
            }
            else
            {
                user.Firstname = txt_Firstname.Text.Trim();
                user.Lastname = txt_Lastname.Text.Trim();
                user.Email = txt_Email.Text.Trim().ToLower();
                user.Username = txt_Username.Text.Trim().ToLower();
                user.Password = txt_Password.Text.Trim();

                inserUserInDB();
            }

            bool validEmail()
            {
                user.Email = txt_Email.Text.Trim();
                try
                {
                    //var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
                    //var pattern = @"^[a-zA-Z][\w\.-]{0,68}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
                    var pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
                    //var pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";
                    var regex = new Regex(pattern);

                    if (!regex.IsMatch(user.Email))
                    {
                        MessageBox.Show("Email address is invalid!\nTry again..");
                        txt_Email.Text = "";
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }

            bool validUsername()
            {
                try
                {
                    connection.Open();

                    user.Username = txt_Username.Text.Trim().ToLower();
                    string query = $"SELECT * FROM tblusers WHERE username= '{user.Username}'";

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = query;

                    SqlDataReader result = cmd.ExecuteReader();

                    bool isExist = false;
                    User u = new User();

                    if (result.Read())
                    {
                        u.Id = result.GetString(0);
                        isExist = true;                        
                    }
                    if (isExist.Equals(true))
                    {
                        MessageBox.Show("There is this username in Database!\nEnter another username.");
                        txt_Username.Text = "";
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }

            void inserUserInDB()
            {
                try
                {
                    string encryptedPassword = Cryptography.Encrypt(user.Password);
                    string query = $"INSERT INTO tblusers(firstname, lastname, email, username, password) " +
                                        $"VALUES (@Firstname, @Lastname, @Email, @Username, @Password);";

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Firstname", user.Firstname);
                    cmd.Parameters.AddWithValue("@Lastname", user.Lastname);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Registered.");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            bool validPassword()
            {
                user.Password = txt_Password.Text.Trim();

                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinMaxChars = new Regex(@".{8,15}");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                if (!hasLowerChar.IsMatch(user.Password))
                {
                    MessageBox.Show("Password must contain at least one lower case letter!");
                    txt_Password.Text = "";
                    txt_ConfirmPass.Text = "";
                    return false;
                } 
                else if(!hasUpperChar.IsMatch(user.Password))
                {
                    MessageBox.Show("Password must contain at least one upper case letter!");
                    txt_Password.Text = "";
                    txt_ConfirmPass.Text = "";
                    return false;
                }
                else if (!hasMinMaxChars.IsMatch(user.Password))
                {
                    MessageBox.Show("Password must not be less than 8 and more than 15 characters long!");
                    txt_Password.Text = "";
                    txt_ConfirmPass.Text = "";
                    return false;
                }
                else if (!hasNumber.IsMatch(user.Password))
                {
                    MessageBox.Show("Password must contain at least one numberic value!");
                    txt_Password.Text = "";
                    txt_ConfirmPass.Text = "";
                    return false;
                }
                else if (!hasSymbols.IsMatch(user.Password))
                {
                    MessageBox.Show("Password must contain at least one special case character!");
                    txt_Password.Text = "";
                    txt_ConfirmPass.Text = "";
                    return false;
                }
                else
                {
                return true;                
                }
            }
        }
         
       
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Email.Text = "";
            txt_Username.Text = "";
            txt_Password.Text = "";
            txt_ConfirmPass.Text = "";
            
        }

        private void btn_LoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); 
        }

        private void btn_HidePassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = false;
            btn_ShowPassword.BringToFront();
        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            btn_HidePassword.BringToFront();
        }

        private void btn_HideConfirmPass_Click(object sender, EventArgs e)
        {
            txt_ConfirmPass.UseSystemPasswordChar = false;
            btn_ShowConfirmPass.BringToFront();
        }

        private void btn_ShowConfirmPass_Click(object sender, EventArgs e)
        {
            txt_ConfirmPass.UseSystemPasswordChar = true;
            btn_HideConfirmPass.BringToFront();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
