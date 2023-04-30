using Medicial.Models;
using Microsoft.EntityFrameworkCore;

namespace Medicial
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
           Database.EnsureCreated();
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Polyclinic> Polyclinics { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<PolyclinicDoctor> PolyclinicDoctors { get; set; }
        public DbSet<SpecializationDoctor> SpecializationDoctors { get; set; }
        
    }
}
