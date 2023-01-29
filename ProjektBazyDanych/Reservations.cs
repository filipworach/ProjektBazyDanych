using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Reservations
    {
        private int v1;
        private int v2;
        private string v3;
        private int v4;
        private DateTime maxValue;
        private int v5;

        [Key]
        public int id { get; set; }
        [Required]
        public int passengerID { get; set; }
        
        [Required]
        [ForeignKey("user_name")]
        public string user_name { get; set; }
        [Required]
        public int flightID { get; set; }
        [Required]
        public DateTime reservation_date { get; set; }
        public bool? processed { get; set; }

        public virtual Flights Flight { get; set; }

        [ForeignKey("user_name")]
        public virtual Accounts Account { get; set; }

        public virtual Passengers Passenger { get; set; }

        public override string ToString()
        {
            return "Id Rezerwacji: " + id + "  Pasażer: " + Passenger.first_name ;
        }

        public Reservations(int id, int passengerID, string user_name, int flightID, DateTime reservation_date, bool? processed)
        {
            this.id = id;
            this.passengerID = passengerID;
            this.user_name = user_name;
            this.flightID = flightID;
            this.reservation_date = reservation_date;
            this.processed = processed;
        }

        public Reservations(int id, int passengerID, string user_name, int flightID, DateTime reservation_date, bool? processed, Flights flight, Accounts account, Passengers passenger) : this(id, passengerID, user_name, flightID, reservation_date, processed)
        {
            this.id = id;
            this.passengerID = passengerID;
            this.user_name = user_name;
            this.flightID = flightID;
            this.reservation_date = reservation_date;
            this.processed = processed;
            Flight = flight;
            Account = account;
            Passenger = passenger;
        }

        public Reservations()
        {

        }

        public Reservations(int v1, int v2, string v3, int v4, DateTime maxValue, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.maxValue = maxValue;
            this.v5 = v5;
        }
    }
}
