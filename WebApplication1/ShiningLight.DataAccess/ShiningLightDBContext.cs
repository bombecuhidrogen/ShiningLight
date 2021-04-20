using Microsoft.EntityFrameworkCore;
using ShinigLight.ApplicationLogic.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningLight.DataAccess
{
    public class ShiningLightDBContext : DbContext
    {
        public ShiningLightDBContext (DbContextOptions<ShiningLightDBContext> options): base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<ClinicServices> ClinicsServices { get; set; }

        public DbSet<Services> Services { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }
    }
}