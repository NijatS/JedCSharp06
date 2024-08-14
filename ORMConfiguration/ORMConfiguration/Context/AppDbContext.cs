using Microsoft.EntityFrameworkCore;
using ORMConfiguration.Models;

namespace ORMConfiguration.Context;

public class AppDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Work> Works { get; set; }
    public DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Desktop-NIJAT;Database=PMS;Encrypt = false;Integrated Security = true;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasKey("VinCode");
            
        modelBuilder.Entity<Car>().Property(x => x.VinCode)
            .HasMaxLength(14);

        modelBuilder.Entity<Car>().HasIndex(x => x.EngineNumber)
            .IsUnique();

        modelBuilder.Entity<Car>().Property(x => x.IsNew)
            .HasDefaultValue(false);
        
        base.OnModelCreating(modelBuilder);
    }
}