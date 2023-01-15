using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    class Reservations
    {
        [Key]
        public int id { get; set; }
        [Required]
        public ICollection<Passengers> passengerID { get; set; }
        [Required]
        public ICollection<Accounts> user_name { get; set; }
        [Required]
        public ICollection<Flights> fligthID { get; set; }
        [Required]
        public DateTime reservation_date { get; set; }
        public bool processed { get; set; }

    }
}
