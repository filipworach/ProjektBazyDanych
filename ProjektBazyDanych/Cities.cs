﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBazyDanych
{
    internal class Cities
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string country { get; set; }

        public string region { get; set; }

    }
}
