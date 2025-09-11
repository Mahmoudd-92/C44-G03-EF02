using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; }

        [ForeignKey("Instructor")]
        public int? Ins_Id { get; set; }

        public Instructor Instructor { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
    }
}
