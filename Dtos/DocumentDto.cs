using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentDto
    {
        public Guid Id { get; set; }

        public DateTimeOffset DocumentDateTime { get; set; }

        public Guid DocumentTypeId { get; set; }

        public int DocumentNumber { get; set; }

        public Guid? DocumentStatusId { get; set; }

        public Guid CustomerId { get; set; }

        public decimal? DocumentTotal { get; set; }

        public string? ShippingAddress { get; set; }

        public string? ShippingRegion { get; set; }

        public int? ShippingPostalCode { get; set; }

        public string? ShippingCity { get; set; }

        public string? ShippingCountry { get; set; }

        public long? ShippingPhone1 { get; set; }

        public long? ShippingPhone2 { get; set; }

        public string? ShippingEmail { get; set; }
    }
}
