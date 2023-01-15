﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    internal class Planes
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string producer { get; set; }

        [Required]
        public string model { get; set; }

        [Required]
        public int max_range{ get; set; }
    }
}