using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string Bio { get; set; }
        //[ForeignKey("User")]        //FK by Data Annotation =>Takes the name of the navigational prop
        public int userId { get; set; }
        public User User { get; set; }
    }

}
