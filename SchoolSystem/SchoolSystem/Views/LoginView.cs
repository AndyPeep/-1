using SchoolSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolSystem.Views
{
    public partial class LoginView : Form
    {
        LoginViewController loginViewController = new LoginViewController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginViewController.AddUser(txtUsername.Text, txtPassword.Text);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
