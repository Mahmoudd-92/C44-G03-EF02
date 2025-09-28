using Inheritance_Mapping.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =MAHMOUD\\SQL2022DEV ; database= EmployeeDbG03; trusted_Connection= true; TrustServerCertificate= true; ")
                .UseLazyLoadingProxies(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Employee>()
            //    .HasDiscriminator<String>("EmployeeType")
            //    .HasValue<FullTimeEmployee>("FullTime")
            //    .HasValue<PartTimeEmployee>("PartTime");

            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

    }
}
