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
        public delegate void delPassData(string text);
        public  delPassData DelPassData;
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
                booking.CheckUser(username, password);
                this.Hide();
                FormMain formMain = new FormMain();
                delPassData del = new delPassData(formMain.GetFormData);
                del(username);
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
