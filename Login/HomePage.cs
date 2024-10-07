using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();           
        }

        public void GetUserData(User User)
        {
            lbl_Username.Text = User.Username;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();            
            loginForm.Show();
        }
    }
}
