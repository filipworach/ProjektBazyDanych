using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Pilots
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        public DateTime hire_date { get; set; }

        public List<Flights> Flights;

        public override string ToString()
        {
            return first_name + " " + last_name;
        }
    }
}
