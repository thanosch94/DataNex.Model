using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class RegisterDto
    {
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string? ClientRegion { get; set; } 
        public string ClientPostalCode { get; set; }
        public string ClientCity { get; set; }
        public string ClientCountry { get; set; }
        public string ClientPhone1 { get; set; }
        public string? ClientPhone2 { get; set; } 
        public string ClientEmail { get; set; }

        public string CompanyName { get; set; } 
        public string CompanyAddress { get; set; }
        public string? CompanyRegion { get; set; } 
        public string CompanyPostalCode { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyPhone1 { get; set; }
        public string? CompanyPhone2 { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyVatNumber { get; set; }
        public string CompanyTaxOffice { get; set; }
        public string CompanyLoginCode { get; set; }
    }



}
