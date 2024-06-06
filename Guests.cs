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
        public IEnumerable<Guest> CheckUser(string username, string password)
        {
            return
                from guest in db.Guests
                where guest.Username == username && guest.Password == password
                select guest;
        }
        public IEnumerable<Guest> CheckUser(int id) {
            return
                from guest in db.Guests
                where guest.Id == id
                select guest;
        }
        private BookingDB db;
    }
}

