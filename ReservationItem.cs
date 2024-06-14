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
    public partial class ReservationItem : UserControl {
        private int id;
        private string apartment;
        private DateTime arrivalDate;
        private DateTime departureDate;
        public ReservationItem() {
            InitializeComponent();
        }
        public int Id {
            get { return id; }
            set {
                id = value;
                lblReservationId.Text = value.ToString();
            }
        }
        public string Apartment {
            get { return apartment; }
            set {
                apartment = value;
                lblApartment.Text = value;
            }
        }
        public DateTime ArrivalDate {
            get { return arrivalDate; }
            set {
                arrivalDate = value;
                dtpArrivalDate.Value = value;
            }
        }
        public DateTime DepartureDate {
            get { return departureDate; }
            set {
                departureDate = value;
                dtpDepartureDate.Value = value;
            }
        }

        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e) {
            dtpDepartureDate.Value = dtpArrivalDate.Value.AddDays(1);
        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e) {
            if (dtpDepartureDate.Value < dtpArrivalDate.Value) {
                dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
            }
        }
    }

}
