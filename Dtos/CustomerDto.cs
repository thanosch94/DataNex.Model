using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        //Billing
        public string? BAddress { get; set; }

        public string? BRegion { get; set; }

        public string? BPostalCode { get; set; }

        public string? BCity { get; set; }

        public string? BCountry { get; set; }

        public int? BPhone1 { get; set; }

        public int? BPhone2 { get; set; }

        public string? BEmail { get; set; }


        //Shipping
        public string? SAddress { get; set; }

        public string? SRegion { get; set; }

        public string? SPostalCode { get; set; }

        public string? SCity { get; set; }

        public string? SCountry { get; set; }

        public int? SPhone1 { get; set; }

        public int? SPhone2 { get; set; }

        public string? SEmail { get; set; }

    }
}
