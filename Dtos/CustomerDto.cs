using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public string Name { get; set; }

        public string? Notes { get; set; }
        public string? Address { get; set; }

        public string? Region { get; set; }

        public string? PostalCode { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? Phone1 { get; set; }

        public string? Phone2 { get; set; }

        public string? Email { get; set; }

        public Guid? VatClassId { get; set; }
        public string? CompanyName { get; set; }

        public string? Occupation { get; set; }
        public int? VatNumber { get; set; } 

        public string? TaxOffice { get; set; }
        public string? UserText1 { get; set; }
        public string? UserText2 { get; set; }
        public string? UserText3 { get; set; }
        public string? UserText4 { get; set; }
        public long? UserNumber1 { get; set; }
        public long? UserNumber2 { get; set; }
        public long? UserNumber3 { get; set; }
        public long? UserNumber4 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public Guid? CompanyId { get; set; }

        public List<CustomerAddressDto> CustomerAddresses { get; set; }

    }
}
