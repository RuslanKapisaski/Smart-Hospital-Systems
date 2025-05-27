using Hospital_System.DAL.Models;
using Hospital_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Hospital_System.DAL.DB
{
    public class HospitalDbContext : DbContext
    {
        // Constructor for dependency injection (used in ASP.NET Core)
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }

        // Parameterless constructor (for migrations and tools)
        public HospitalDbContext() : base()
        {
        }

        // Configure PostgreSQL connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["PGConnectionString"].ConnectionString;

            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set default schema to 'public'
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        // DbSets (Database tables)
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}