﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.Woocommerce
{
    public class WooCategoryDto
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? slug { get; set; }
        public int? parent { get; set; }
        public string? description { get; set; }
        public string? display { get; set; }
        public Object? image { get; set; }
        public int? menu_order { get; set; }
        public int? count { get; set; }
    }
}
