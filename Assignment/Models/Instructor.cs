using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }
        public double HourRate { get; set; }
        public ICollection<Department> Departments { get; set; }

        [ForeignKey("Department")]
        public int? Dep_Id { get; set; }
        public Department Department { get; set; }

    }
}
