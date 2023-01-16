using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Flights
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int first_pilot { get; set; }

        [Required]
        public int second_pilot { get; set; }

        [Required]
        public int connectionID { get; set; }

        [Required]
        public DateTime departure_date { get; set; }

        [Required]
        public DateTime arrival_date { get; set; }

        [Required]
        public string plane_id { get; set; }

        [Required]
        public bool canceled { get; set; }

        
        public virtual List<Reservations> Reservations { get; set; }

    }
}
