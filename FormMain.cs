using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Booking {
    public partial class FormMain : Form {
        private Booking booking;
        public FormMain() {
            InitializeComponent();
            booking = new Booking();
            RefreshCityList();
            
        }
        private void RefreshCityList() {
            cbCity.Items.Clear();
            foreach (var city in booking.Cities.All()) {
                cbCity.Items.Add(city.City1);
            }
        }
        public void GetFormData(string username) {
            lblGuest.Text = username;
        }
        private void ShowCityApartments(string city) {

            
            var data = booking.Apartments.ShowApartments(city);
            
            foreach (var apartment in data) { 
                ListItem listItem = new ListItem();
                listItem.Name = apartment.Name;
                listItem.Address = apartment.Address;
                listItem.Price = apartment.Price;
                listItem.Picture = apartment.Pictures;
                flpApartments.Controls.Add(listItem);
            }          
                
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e) {
            flpApartments.Controls.Clear();
            ShowCityApartments(cbCity.Text);
            
        }

    }
}
