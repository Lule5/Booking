﻿using System;
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
        public delegate void delPassData(int id);
        public  delPassData DelPassData;
        private Guests guests;
        public LoginForm()
        {
            InitializeComponent();
            guests = new Guests();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            

            try {
                var validUser=guests.CheckUser(username, password);
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
    }
}
