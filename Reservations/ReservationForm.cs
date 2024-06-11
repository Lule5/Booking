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
        public ReservationForm() {
            InitializeComponent();
            apartments = new Apartments();
            dtpArrivalDate.MinDate = DateTime.Now;
            dtpDepartureDate.MinDate = dtpArrivalDate.Value.AddDays(1);
        }
        public void GetFormData(int id) {
            var apartment = apartments.ShowApartment(id);
            pbApartmentPicture.Load(apartment.Pictures);
            lblApartmentName.Text = apartment.Name;
            lblApartmentAddress.Text = apartment.Address;
            lblApartmentCity.Text = apartment.City.City1;
            
        }
    }
}
