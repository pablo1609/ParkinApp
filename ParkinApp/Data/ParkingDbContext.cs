using Microsoft.EntityFrameworkCore;
using ParkingApp.Configurations;
using ParkingApp.Entities;

namespace ParkinApp.Data;

public class ParkingDbContext : DbContext
{
    
    public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
    {
    }

    public DbSet<ParkingSpot> ParkingSpots { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new ParkingSpotConfiguration());
    }
}