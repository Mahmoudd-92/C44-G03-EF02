using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? age { get; set; }
        public string? Address { get; set; }
        //public string Discriminator { get; set; }
    }
}
