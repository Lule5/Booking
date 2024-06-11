using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Booking {
    public partial class BookingDB : DbContext {
        public BookingDB()
            : base("name=DBBooking") {
        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Apartment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Apartment>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Apartment)
                .HasForeignKey(e => e.IdApartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .Property(e => e.City1)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Apartments)
                .WithRequired(e => e.City)
                .HasForeignKey(e => e.IdCity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.OIB)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Guest)
                .HasForeignKey(e => e.IdGuest)
                .WillCascadeOnDelete(false);
        }
    }
}
