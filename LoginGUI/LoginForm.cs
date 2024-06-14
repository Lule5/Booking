using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking {
    public partial class LoginForm : Form {
        public delegate void delPassData(int id);
        public delPassData DelPassData;
        private Guests guests;
        public LoginForm() {
            InitializeComponent();
            guests = new Guests();
            Task.Run(() => CheckDatabaseConnection());
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string username = tbUsername.Text;
            string password = tbPassword.Text;


            try {
                var validUser = guests.CheckUser(username, password);
                this.Hide();
                FormMain formMain = new FormMain();
                delPassData del = new delPassData(formMain.GetFormData);
                del(validUser.Id);
                formMain.ShowDialog();
                this.Close();

            } catch (Exception ex) {
                tbUsername.Text = "";
                tbPassword.Text = "";
                lblError.Text = ex.Message;
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnLogin_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
        private void CheckDatabaseConnection() {
            try {
                using (var db = new BookingDB()) {
                    db.Database.Connection.Open();

                    var dumdummyQuery = from g in db.Guests
                                        select g;
                }



                BeginInvoke(new Action(() => {
                    MessageBox.Show("Database connection successful.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            } catch (Exception ex) {

                BeginInvoke(new Action(() => {
                    MessageBox.Show($"Database connection failed: {ex.Message}", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }
    }
}
