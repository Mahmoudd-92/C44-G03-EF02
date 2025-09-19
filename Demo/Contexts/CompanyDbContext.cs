using Demo.Configuration;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Contexts
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =MAHMOUD\\SQL2022DEV ; database= CompanyDbG03; trusted_Connection= true; TrustServerCertificate= true; ")
                .UseLazyLoadingProxies(false);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<User>()     //Fk by Fluent API (mn al user mawgoad f userprofile 1 to 1)
                .HasOne(x => x.UserProfile)
                .WithOne(x => x.User)
                .HasForeignKey<UserProfile>(x => x.userId);

            modelBuilder.Entity<Category>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId); //not important can run with out it but firstly
                                                   //remove CategoryId prop from products.

            //modelBuilder.Entity<Student>()
            //    .HasMany(x => x.Courses)
            //    .WithMany(x => x.Students);

            modelBuilder.Entity<StudentCourse>()              //Setting a composite PK by Fluent API.
                .HasKey(x => new { x.StudentID, x.CourseID });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
    }
}
