using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Apartments{
        public Apartments() {
            db = new BookingDB();
        }
        public IEnumerable<Apartment> All()
        {
            return
              from apartment in db.Apartments
              orderby apartment.Name
              select apartment;

        }
        private BookingDB db;

    }
}
