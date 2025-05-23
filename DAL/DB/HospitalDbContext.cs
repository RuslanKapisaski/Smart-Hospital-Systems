using Hospital_System.DAL.Models;
using Hospital_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.DAL.DB
{
    public class HospitalDbContext : DbContext
    {
        //connection to PostgreSQL
        public HospitalDbContext() : base(nameOrConnectionString: "PGConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Payment> Payments { get; set; }
        
        public DbSet<Role> Roles { get; set; }

        public List<User> GetAllUsers { get; set; }


    }
}
