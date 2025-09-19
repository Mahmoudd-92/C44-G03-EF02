using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    [PrimaryKey(nameof(CourseID),nameof(StudentID))]  //Setting a composite PK by Data Annotation.
    public class StudentCourse
    {
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int Grade { get; set; }
    }
}
