using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        //public int UserProfileId { get; set; }          //FK by convention (mmkn mktbhash 3ady w it'll be created auyomaticly 
        //bas msh hyb'a lea representation hna f al DB bas (ystahsn t3mlha b"ydk))
        public virtual UserProfile UserProfile { get; set; }      //FK By Convention --Navigational prop 
    }
}
