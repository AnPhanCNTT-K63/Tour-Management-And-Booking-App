using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
