using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    public class Planes
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string producer { get; set; }

        [Required]
        public string model { get; set; }

        [Required]
        public int max_range{ get; set; }

        public override string ToString()
        {
            return ID + " " + producer + " " + model;
        }
    }
}
