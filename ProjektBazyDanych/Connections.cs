using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Connections
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int departure_cityID { get; set; }

        [ForeignKey("departure_cityID")]
        public virtual Cities departureCity { get; set; }

        [ForeignKey("arrival_cityID")]
        public virtual Cities arrivalCity { get; set; }

        [Required]
        public int arrival_cityID { get; set; }


        //public virtual List<Flights> Flights { get; set; }

        public Connections(int id, int departure_cityID, int arrival_cityID)
        {
            this.ID = id;
            this.departure_cityID = departure_cityID;
            this.arrival_cityID = arrival_cityID;
        }
        public Connections() { }

        public override string ToString()
        {
            return departureCity.ToString() + " - " + arrivalCity.ToString();
        }
    }
}
