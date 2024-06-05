using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class Cities{
        public Cities() { 
            db = new BookingDB();
        }

        public IEnumerable<City> All(){
            return 
                from city in db.Cities
                orderby city.City1
                select city;
        }
        private BookingDB db;
    }
}
