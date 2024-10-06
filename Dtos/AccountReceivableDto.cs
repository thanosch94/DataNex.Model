﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class AccountReceivableDto
    {
        public Guid CustomerId {  get; set; }

        public string CustomerName { get; set; }

        public decimal? ReceivableTotal { get; set; }
    }
}
