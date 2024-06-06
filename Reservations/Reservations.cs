using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Reservations{
        public Reservations()
        {
            db = new BookingDB();
        }

        public IEnumerable<Reservation> All()
        {
            return
                from reservation in db.Reservations
                orderby reservation.Id
                select reservation;
        }
        private BookingDB db;
    
    }
}
