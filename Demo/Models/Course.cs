using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public ICollection<Student> Students { get; set; }
        public virtual ICollection<StudentCourse> studentCourses { get; set; }

    }
}
