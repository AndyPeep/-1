using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolSystem.Controllers
{
    public class LoginViewController
    {
        public void AddUser(string username, string password)
        {
            MessageBox.Show("User " + username + " was added to the system!");
        }
    }
}
