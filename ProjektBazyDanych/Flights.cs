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

        [ForeignKey("id")]
        public Connections connection { get; set; }

        [Required]
        public DateTime departure_date { get; set; }


        [Required]
        public DateTime arrival_date { get; set; }

        [Required]
        public string plane_id { get; set; }

        [Required]
        public bool canceled { get; set; }

        //public virtual Connections Connections { get; set; }

        public override string ToString() {
            return "Data odlotu: " + departure_date.ToString() + "      Data przylotu: " + arrival_date.ToString();
                }
        public virtual List<Reservations> Reservations { get; set; }

        public Flights(int id, int first_pilot, int second_pilot, int connectionID, DateTime departure_date, DateTime arrival_date, string plane_id, bool canceled)
        {
            this.id = id;
            this.first_pilot = first_pilot;
            this.second_pilot = second_pilot;
            this.connectionID = connectionID;
            this.departure_date = departure_date;
            this.arrival_date = arrival_date;
            this.plane_id = plane_id;
            this.canceled = canceled;
        }
        public Flights() { }
    }
}
