using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    class Passengers
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string first_name { get; set; }
        [Required]
        public DateTime birth_date { get; set; }
        [Required]
        public string passportID { get; set; }
 
        public string user_name { get; set; }
    }
}
