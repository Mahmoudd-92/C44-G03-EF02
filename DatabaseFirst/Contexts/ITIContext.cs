
using DatabaseFirst.Contexts.Configurations;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace DatabaseFirst.Contexts;

public partial class ITIContext : DbContext
{
    public ITIContext()
    {
    }

    public ITIContext(DbContextOptions<ITIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CariroStudView> CariroStudViews { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<StudCourseGrade> StudCourseGrades { get; set; }

    public virtual DbSet<Stud_Course> Stud_Courses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MAHMOUD\\SQL2022DEV;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.CariroStudViewConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CourseConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudCourseGradeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.Stud_CourseConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StudentConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
