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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Desktop-Nijat;Database=HMS1;Integrated Security = true;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
    }

}
