﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_suppliers")]
    public class Supplier:Person
    {
        public Supplier() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
