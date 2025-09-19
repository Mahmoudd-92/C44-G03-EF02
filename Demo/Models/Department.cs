using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public virtual DateTime DateOfCreation { get; set; }
        public int Serial { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
