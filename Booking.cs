using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking {
    public class Booking {
        private Cities cities;
        private Guests guests;
        private Apartments apartments;
        private Reservations reservations;
        public Booking() { 
            cities = new Cities();
            guests = new Guests();
            apartments = new Apartments();
            reservations = new Reservations();
        }
        public void CheckUser(string username, string password) {
            var validUser = guests.CheckUser(username, password).Any();
            if (!validUser) {
                throw new Exception("Invalid username or password!");
            }
        }
        
        public Cities Cities { get { return cities; } }
        public Guests Guests { get { return guests; } }
        public Apartments Apartments { get { return apartments; } }
        public Reservations Reservations { get { return reservations; } }
        
       

    }
}
