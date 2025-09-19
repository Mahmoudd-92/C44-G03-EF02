using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; } //FK by convention will create           (1 : M) Relationship
                                                           //CategoryId column in the products table
                                                           //Naming comes from the Class name and
                                                           //putting ID in the last of it
    }
}
