using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking {
    public class Login {
        private Guests guests;
        public Login() { 
            guests = new Guests();
        
        }

        public void checkUser(string username, string password) { 
            var validUser = guests.CheckUser(username, password).Any();
            if (!validUser) {
                throw new Exception("Invalid username or password!");
            }
        }
    }
}
