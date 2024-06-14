using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Booking {
    public partial class FormMain : Form {
        
        private Cities cities;
        private Guests guests;
        private Apartments apartments;
        private Reservations reservations;
        private Guest Guest {  get; set; }
        
        public FormMain() {
            InitializeComponent();
            cities = new Cities();
            apartments = new Apartments();
            guests = new Guests();
            reservations = new Reservations();
            RefreshCityList();


        }
      
        private void RefreshCityList() {
            cbCity.Items.Clear();
            foreach (var city in cities.All()) {
                cbCity.Items.Add(city.City1);
            }
        }
        public void GetFormData(int id) {
            try {
                Guest = guests.CheckUser(id);
                lblGuest.Text = Guest.Name;
                showReservations(Guest.Id);


            } catch (Exception ex) { 
                lblGuest.Text = ex.Message;
            }
        }


        private void ShowCityApartments(string city) {
            var data = apartments.ShowApartments(city);
            
            foreach (var apartment in data) { 
                ListItem listItem = new ListItem(Guest);
                listItem.SomeEvent += ListItem_SomeEvent;
                listItem.Id = apartment.Id;
                listItem.Name = apartment.Name;
                listItem.Address = apartment.Address;
                listItem.Price = apartment.Price;
                listItem.Picture = apartment.Pictures;
                flpApartments.Controls.Add(listItem);
            }          
                
        }
        public void showReservations(int id) {
            flpReservations.Controls.Clear();
            var data = reservations.ShowGuestReservations(id);
            foreach (var reservation in data) {
                ReservationItem listItem  = new ReservationItem(Guest);
                listItem.SomeEvent += ReservationItem_SomeEvent;
                listItem.Id = reservation.Id;
                listItem.Apartment = reservation.Apartment;
                listItem.ArrivalDate = (DateTime)reservation.ArrivalDate;
                listItem.DepartureDate = (DateTime)reservation.DepartureDate;
                flpReservations.Controls.Add(listItem);
            }

        }
        private void ReservationItem_SomeEvent(object sender, EventArgs e) {
            
           showReservations(Guest.Id);
        }
        private void ListItem_SomeEvent(object sender, EventArgs e) {
            this.Hide();
            this.Close();
        }




        private void cbCity_SelectedIndexChanged(object sender, EventArgs e) {
            flpApartments.Controls.Clear();
            ShowCityApartments(cbCity.Text);

        }
        
            
            
        
    }
}
