namespace Booking
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        public Reservation(int id, int idApartment, int idGuest, DateTime? arrivalDate, DateTime? departureDate)
        {
            IdApartment = idApartment;
            IdGuest = idGuest;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;

        }

        public int Id { get; set; }

        public int IdApartment { get; set; }

        public int IdGuest { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DepartureDate { get; set; }

        public virtual Apartment Apartment { get; set; }

        public virtual Guest Guest { get; set; }
    }
}
