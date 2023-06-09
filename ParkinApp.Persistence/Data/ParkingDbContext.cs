using Microsoft.EntityFrameworkCore;
using ParkinApp.Domain.Entities;
using ParkinApp.Persistence.Configurations;

namespace ParkinApp.Persistence.Data
{
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
        {
        }

        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ParkingSpotConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
        }
    }
}