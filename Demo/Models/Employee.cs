using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    //By Convention
    //By Data Annotation
    //[Table("EmployeeTable")]
    public class Employee
    {
        public int Id { get; set; } // Id, EmployeeId ==> PK, Identity (1,1) 

        [Column(TypeName = "Varchar")]
        [MaxLength(10)]
        [MinLength(5)]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "max = 10")]
        [Length(5, 10)]
        public string? Name { get; set; } //nvarchar(max)

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        [Range(18, 60)]
        [AllowedValues(22, 44, 11)]
        [DeniedValues(33, 24, 55)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [NotMapped]
        public int Test { get; set; }

        //[RegularExpression()]
        public string password { get; set; }

        public string address { get; set; }

        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
