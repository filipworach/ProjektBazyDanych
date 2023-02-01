using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Passengers
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public DateTime birth_date { get; set; }
        [Required]
        public string passportID { get; set; }
 
        public string user_name { get; set; }
        
        //public virtual List<Reservations> Reservations { get; set; }

        public Passengers(int id, string first_name,string last_name, DateTime birth_date, string passportID, string user_name)
        {
            this.ID = id;
            this.first_name = first_name;
            this.birth_date = birth_date;
            this.passportID = passportID;
            this.user_name = user_name;
            this.last_name = last_name;
        }
        public Passengers() { }
    }
}
