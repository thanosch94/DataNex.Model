﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    public class Person:BaseModel
    {
        public virtual string Name { get; set; }


        public virtual string? Address { get; set; }

        public virtual string? Region { get; set; }

        public virtual string? PostalCode { get; set; }

        public virtual string? City { get; set; }

        public virtual string? Country { get; set; }

        public virtual string? Phone1 { get; set; }

        public virtual string? Phone2 { get; set; }

        public virtual string? Email { get; set; }

        public virtual int? VatNumber { get; set; }

        public virtual string? TaxOffice { get; set; }

        public virtual Guid? CompanyId { get; set; }

    }
}
