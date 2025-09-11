using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Contexts
{
    public class ITiDbContext : DbContext
    {
        public ITiDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =MAHMOUD\\SQL2022DEV ; database= ITI02; trusted_Connection= true; TrustServerCertificate= true; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Department>()
                .HasMany(X => X.Instructors)
                .WithOne(X => X.Department);
          
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }

    }
}
