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
        public IEnumerable<Apartment> ShowApartments(string city) {
            return
              from apartment in db.Apartments
              join c in db.Cities on apartment.IdCity equals c.Id
              where c.City1 == city
              select apartment;

        }
        private BookingDB db;

    }
}
