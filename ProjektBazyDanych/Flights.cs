using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    internal class Flights
    {
        [Key]
        public int id { get; set; }

        [ForeignKey ("id")]
        [Required]
        public int first_pilot { get; set; }


        [ForeignKey("id")]
        [Required]
        public int second_pilot { get; set; }

        [ForeignKey("id")]
        [Required]
        public int connectionID { get; set; }

        [Required]
        public DateTime departure_date { get; set; }

        [Required]
        public DateTime arrival_date { get; set; }

        [ForeignKey("id")]
        [Required]
        public string plane_id { get; set; }

        [Required]
        public bool canceled { get; set; }
        

    }
}
