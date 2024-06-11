using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                    from r in db.Reservations
                    orderby r.Id
                    select r;
            
        }
        public void Add(Reservation reservation) {
            db.Reservations.Add(reservation);
            db.SaveChanges();
        }
        public void Update(Reservation reservation) {
            db.Reservations.AddOrUpdate(reservation);
            db.SaveChanges();
        }
        public IEnumerable<Reservation> ShowGuestReservations(int id) {
            return
                from reservation in db.Reservations
                where reservation.IdGuest == id
                select reservation;
        }

        private BookingDB db;
    
    }
}
