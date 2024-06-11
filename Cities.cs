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
        public City GetCity(string city) {
            return
                (from c in db.Cities
                where c.City1 == city
                select c).First();
        }
        
        private BookingDB db;
        
    }
}
