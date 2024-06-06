using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class LoginForm : Form
    {
        private Login login;
        public LoginForm()
        {
            InitializeComponent();
            login = new Login();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            

            try {
                login.checkUser(username, password);
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
                this.Close();
                
            } catch (Exception ex) {
                tbUsername.Text = "";
                tbPassword.Text = "";
                lblError.Text = ex.Message;
            }
        }
    }
}
