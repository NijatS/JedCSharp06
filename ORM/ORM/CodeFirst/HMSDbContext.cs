using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ORM.CodeFirst
{
    public class HMSDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Student> Students { get; set; }    
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; } 
        public DbSet<Order> Orders { get; set; }    
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Desktop-Nijat;Database=HMS1;Integrated Security = true;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.ProductId, x.OrderId });
            base.OnModelCreating(modelBuilder);
        }
    }

}
