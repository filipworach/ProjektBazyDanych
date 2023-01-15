using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    class Connections
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int departure_cityID { get; set; }
        [Required]
        public int arrival_cityID { get; set; }

        public Cities departureCity { get; set; }
        public Cities arrivalCity { get; set; }
        public List<Flights> Flights { get; set; }
    }
}
