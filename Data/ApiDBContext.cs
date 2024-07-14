using Microsoft.EntityFrameworkCore;
using PostgresAndEFCore.Models;

namespace PostgresAndEFCore.Data;

// This class manages the connection between the app and the database
// It manages the mapping of the entities to the database tables and their relationships
// It manages the migrations of the database
// The constructor accepts DbContextOptions<ApiDBContext> as a parameter, which is a pattern for configuring the DbContext with options (like the database provider, connection strings, etc.). This is passed to the base DbContext class.
public class ApiDBContext(DbContextOptions<ApiDBContext> options) : DbContext(options)
{
  // DbSet<T> properties represent collections of entities that EF Core will manage.
  // This property is a DbSet of the Team entity
  // It will be mapped to a table named "team" in the database
  public DbSet<Team> Teams { get; set; } = null!;
  // This property is a DbSet of the Driver entity
  // It will be mapped to a table named "driver" in the database
  public DbSet<Driver> Drivers { get; set; } = null!;
  // This property is a DbSet of the DriverMedia entity
  // It will be mapped to a table named "driver_media" in the database
  public DbSet<DriverMedia> DriversMedia { get; set; } = null!;


  // This method is called when the database is being created
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    // This method is called to configure the model
    // The entities are passed to the modelBuilder.Entity method
    // The entities are mapped to the tables in the database
    modelBuilder.Entity<Team>(entity =>
    {
      entity.ToTable("team");
    });

    modelBuilder.Entity<Driver>(entity =>
    {
      entity.ToTable("driver");
      entity.HasOne(e => e.Team).WithMany(e => e.Drivers).HasForeignKey(e => e.TeamId).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_team_has_drivers");
    });

    modelBuilder.Entity<DriverMedia>(entity =>
    {
      entity.ToTable("driver_media");
      entity.HasOne(e => e.Driver).WithOne(e => e.DriverMedia).HasForeignKey<DriverMedia>(e => e.DriverId);
    });
  }
}
