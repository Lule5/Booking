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
                lblPrice.Text = value.ToString();
            }
        }
        public string Picture {
            get { return picture; }
            set {
                picture = value;
                pbApartment.Load(value);
            }
        }
    }
}
