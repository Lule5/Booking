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
        public void checkUser(string username, string password) {
            var validUser = guests.CheckUser(username, password).Any();
            if (!validUser) {
                throw new Exception("Invalid username or password!");
            }
        }
        public IEnumerable<City> GetCities() {
            return cities.All();
        }
        public IEnumerable<Apartment> GetApartments() {
            return apartments.All();
        }

    }
}
