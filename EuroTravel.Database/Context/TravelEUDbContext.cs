using Microsoft.EntityFrameworkCore;
using TravelEU.Database.Models;

namespace TravelEU.Database.Context;

public class TravelEUDbContext : DbContext
{
    public TravelEUDbContext(DbContextOptions<TravelEUDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Destination> Destinations { get; set; }

    public DbSet<Tour> Tours { get; set; }

    public DbSet<Member> Members { get; set; }

    public DbSet<Group> Groups { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<Authorize> Authorizes { get; set; }

    public DbSet<Booking> Bookings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Composite Key
        modelBuilder.Entity<Authorize>()
            .HasKey(a => new { a.GroupId, a.RoleId });

        // Group - Authorize
        modelBuilder.Entity<Authorize>()
            .HasOne(a => a.Group)
            .WithMany(g => g.Authorizes)
            .HasForeignKey(a => a.GroupId);

        // Role - Authorize
        modelBuilder.Entity<Authorize>()
            .HasOne(a => a.Role)
            .WithMany(r => r.Authorizes)
            .HasForeignKey(a => a.RoleId);
    }
}