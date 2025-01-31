using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentDto
    {
        public Guid Id { get; set; }
        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public DateTimeOffset DocumentDateTime { get; set; }

        public Guid DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }

        public int DocumentNumber { get; set; }

        public Guid? DocumentStatusId { get; set; }
        public string? DocumentStatusName { get; set; }

        public Guid? CustomerId { get; set; }
        public Guid? SupplierId { get; set; }

        public Guid? CompanyId { get; set; }


        public string? CustomerName { get; set; }

        public string? CustomerPhone1 { get; set; }

        public decimal? DocumentTotal { get; set; }

        public string? ShippingAddress { get; set; }

        public string? ShippingRegion { get; set; }

        public string? ShippingPostalCode { get; set; }

        public string? ShippingCity { get; set; }

        public string? ShippingCountry { get; set; }

        public string? ShippingPhone1 { get; set; }

        public string? ShippingPhone2 { get; set; }

        public string? ShippingEmail { get; set; }

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
        public string DocumentCode { get; set; }
        public Guid VatClassId { get; set; }
    }
}
