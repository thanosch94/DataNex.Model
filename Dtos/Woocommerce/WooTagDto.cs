﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.Woocommerce
{
    public class WooTagDto
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? slug { get; set; }
    }
}
