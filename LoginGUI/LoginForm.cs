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
        private Booking booking;
        public LoginForm()
        {
            InitializeComponent();
            booking = new Booking();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            

            try {
                booking.checkUser(username, password);
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
