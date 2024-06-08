using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Booking.LoginForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Booking {
    public partial class ListItem : UserControl {
        private string name;
        private string address;
        private double price;
        private string picture;
        public ListItem() {
            InitializeComponent();
        }

        public string Name {
            get { return name; } 
            set {
                name = value;
                lblName.Text = name;
            }
        }
        public string Address {
            get { return address; }
            set {
                address = value;
                lblAddress.Text = address;
            }
        }
        public double Price {
            get { return price; }
            set {
                price = value;
                lblPrice.Text = value + "€ per night";
            }
        }
        public string Picture {
            get { return picture; }
            set {
                picture = value;
                pbApartment.Load(value);
            }
        }

      
            
        private void ListItem_MouseEnter(object sender, EventArgs e) {
            this.BackColor = Color.Silver;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e) {
            this.BackColor = SystemColors.Control;
        }

        private void ListItem_MouseDoubleClick(object sender, MouseEventArgs e) {
            ReservationForm reservationForm = new ReservationForm();
            
            reservationForm.ShowDialog();
        }
    }
}
