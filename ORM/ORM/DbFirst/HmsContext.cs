//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace ORM.Entities;

//public partial class HmsContext : DbContext
//{
//    public HmsContext()
//    {
//    }

//    public HmsContext(DbContextOptions<HmsContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Doctor> Doctors { get; set; }

//    public virtual DbSet<Patient> Patients { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=Desktop-NIJAT;\nInitial Catalog=HMS;Integrated Security=True;Connect Timeout=30;\nEncrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;\nMulti Subnet Failover=False");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Doctor>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Doctors__3214EC078C0052F2");

//            entity.Property(e => e.Email).HasMaxLength(50);
//            entity.Property(e => e.Specialty).HasMaxLength(50);
//        });

//        modelBuilder.Entity<Patient>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("PK__Patients__3214EC079CB89F8E");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
