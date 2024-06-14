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
    public partial class ReservationForm : Form {
        private Apartments apartments;
        public Apartment Apartment { get; set; }
        public Guest Guest { get; set; }
        public Reservation Reservation { get; set; }
        private Reservations reservations;
        public ReservationForm() {
            InitializeComponent();
            apartments = new Apartments();
            reservations = new Reservations();

            dtpArrivalDate.MinDate = DateTime.Now;
            dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
        }
        public void GetFormData(int idApartment) {
            Apartment = apartments.ShowApartment(idApartment);
            pbApartmentPicture.Load(Apartment.Pictures);
            lblApartmentName.Text = Apartment.Name;
            lblApartmentAddress.Text = Apartment.Address;
            lblApartmentCity.Text = Apartment.City.City1;

        }
        public void GetGuestData(Guest guest) { 
            Guest = guest;
        }

        
        private double getPrice() {
            double price=0;
            if (Apartment != null) {
                TimeSpan duration = dtpDepartureDate.Value.Subtract(dtpArrivalDate.Value);
                int bookingDays = duration.Days;
                price = Apartment.Price * bookingDays;
            }
            return price;

        }
        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e) {
            dtpDepartureDate.Value = dtpArrivalDate.Value.AddDays(1);
            lblPrice.Text = $"{getPrice()}€";
        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e) {
            if (dtpDepartureDate.Value < dtpArrivalDate.Value) {
                dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
            }
            lblPrice.Text = $"{getPrice()}€";
        }

        private void btnReserve_Click(object sender, EventArgs e) {
            Reservation reservation = new Reservation();
            reservation.IdGuest = Guest.Id;
            reservation.IdApartment = Apartment.Id;
            reservation.ArrivalDate = dtpArrivalDate.Value;
            reservation.DepartureDate = dtpDepartureDate.Value;
            reservations.Add(reservation);
            MessageBox.Show(String.Format("You have successfully booked {0}", Apartment.Name));
                

        }

        
    }
}
