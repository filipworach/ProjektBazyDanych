using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Accounts
    {
        [Key]
        public string user_name { get; set; }
        [Required]
        public string password { get; set; }
        [ForeignKey("user_name")]
        public List<Reservations> reservations { get; set; }

        public Accounts(string user_name, string password)
        {
            this.user_name = user_name;
            this.password = password;
           
        }

        public Accounts()
        {

        }
    }
}
