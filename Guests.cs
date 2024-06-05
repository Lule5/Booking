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
        private BookingDB db;
    }
}

