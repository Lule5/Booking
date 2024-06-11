using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Guests{
        public Guests() {
            db = new BookingDB();
        }

        public IEnumerable<Guest> All()
        {
            return
                from guest in db.Guests
                select guest;
        }
        public Guest CheckUser(string username, string password)
        {
            var validUser = (from guest in db.Guests
                             where guest.Username == username && guest.Password == password
                             select guest).FirstOrDefault();
            if (validUser==null) {
                throw new Exception("Invalid username or password!");
            }
            return validUser;
                
        }
        public Guest CheckUser(int id) {
            var guest=
                (from g in db.Guests
                where g.Id == id
                select g).FirstOrDefault();
            if (guest == null) {
                throw new Exception("User not found!");
            }
            return guest;
        }

        private BookingDB db;
    }
}

