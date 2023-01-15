using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    class Accounts
    {
        [Key]
        public string user_name { get; set; }
        [Required]
        public string password { get; set; }        
    }
}
