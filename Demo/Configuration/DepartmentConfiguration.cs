using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.DeptId);
            builder.Property(x => x.DeptId)
                   .UseIdentityColumn(10, 10);

            //builder.Property(x => x.DeptId)
            //       .ValueGeneratedNever();            //No Identity will be created

            //builder.Property(x => x.DeptId)
            //       .HasDefaultValueSql("newGuid()");  // Globally Unique Identifier

            builder.Property(x => x.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50)
                   .HasColumnName("Department Name")
                   .IsRequired(false)
                   .HasDefaultValue("HR");

            builder.Property(x => x.DateOfCreation)
                   .HasAnnotation("DataType", "Data")
                   //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))
                   .HasDefaultValueSql("GetDate()");

            builder.Ignore(x => x.Serial);
        }
    }
}
