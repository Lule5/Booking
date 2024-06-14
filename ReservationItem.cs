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
        private Apartment apartment;
        private DateTime arrivalDate;
        private DateTime departureDate;
        private Reservations reservations;
        public ReservationItem(Guest guest) {
            InitializeComponent();
            Guest = guest;  
            reservations = new Reservations();
        }
        public Guest Guest;
        public int Id {
            get { return id; }
            set {
                id = value;
                lblReservationId.Text = value.ToString();
            }
        }
        public Apartment Apartment {
            get { return apartment; }
            set {
                apartment = value;
                lblApartment.Text = value.Name;
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

        public FormMain Owner { get; private set; }

        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e) {
            dtpDepartureDate.Value = dtpArrivalDate.Value.AddDays(1);
        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e) {
            if (dtpDepartureDate.Value < dtpArrivalDate.Value) {
                dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            Reservation reservation = new Reservation();
            reservation.Id = Int32.Parse(lblReservationId.Text);
            reservation.IdApartment = Apartment.Id;
            reservation.IdGuest = Guest.Id;
            reservation.ArrivalDate = dtpArrivalDate.Value;
            reservation.DepartureDate = dtpDepartureDate.Value;
            reservations.Update(reservation);
            MessageBox.Show("You have successfully updated your reservation");

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var reservationId = Int32.Parse(lblReservationId.Text);
            reservations.Delete(reservationId);
            MessageBox.Show("You have successfully deleted your reservation");
            
            
        }
    }

}
