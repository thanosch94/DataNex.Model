﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Region { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string Email { get; set; }

    }
}
