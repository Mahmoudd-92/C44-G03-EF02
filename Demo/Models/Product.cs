using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[ForeignKey("Category")] //1:M    by Annotation
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
