using GymBooking.DAL;
using Microsoft.EntityFrameworkCore;

namespace GymBooking.Data
{
    public class GymContext:DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<GymArea> Areas { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = GymBookingData");
            
        }
    }
}
