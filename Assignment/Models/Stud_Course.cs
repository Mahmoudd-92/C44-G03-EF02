using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    //By Convention
    //msh 3aref a3mlha w maktoob an Composite key → only possible with Fluent API.
    //hkhly al stud_Id hwa al PK
    public class Stud_Course
    {
        [Key]
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public double Grade { get; set; }
    }
}
