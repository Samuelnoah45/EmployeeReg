namespace PostgresDb.Data;

using Microsoft.EntityFrameworkCore;
using PostgresDb.Models;

public class ApiDbContext : DbContext
{

    public virtual DbSet<Driver> Drivers { get; set; }
    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<DriverMedia> DriverMedias { get; set; }
    public virtual DbSet<Car> Cars { get; set; }
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 1-many
        modelBuilder.Entity<Driver>(entity =>
        {
            entity.HasOne(t => t.Team)
            .WithMany(d => d.Drivers)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_Driver_Team")
            .HasForeignKey(x => x.TeamId);
            // 1-1
            entity.HasOne(dm => dm.DriverMedia)
                .WithOne(d => d.Driver)
                .HasForeignKey<DriverMedia>(x => x.DriverId);
            
        });

        modelBuilder.Entity<Car>(ent=>{
            ent.HasOne(d => d.Driver)
            .WithMany(c => c.Cars)
            .HasForeignKey(x => x.DriverId);
        });
    }
}