using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DataNex.Model.Models
{
    [Table("datanex_documents")]
    public class Document:BaseModel
    {
        public Document()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public DateTimeOffset DocumentDateTime { get; set; }

        public Guid DocumentTypeId { get; set; }

        public DocumentType DocumentType { get; set; }

        public int DocumentNumber { get; set; }

        [StringLength(20)]
        public string DocumentCode { get; set; }

        public Guid? DocumentStatusId { get; set; }

        public Status? DocumentStatus { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Precision(18, 2)]
        public decimal? DocumentTotal { get; set; }

        [StringLength(255)]
        public string? ShippingAddress { get; set; }

        [StringLength(50)]
        public string? ShippingRegion { get; set; }

        public int? ShippingPostalCode { get; set; }

        [StringLength(50)]
        public string? ShippingCity { get; set; }

        [StringLength(50)]
        public string? ShippingCountry { get; set; }

        public long? ShippingPhone1 { get; set; }

        public long? ShippingPhone2 { get; set; }

        [StringLength(255)]
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
        public ICollection<DocumentProduct> DocumentProducts { get; set; } = new HashSet<DocumentProduct>();
        public ICollection<DocumentAdditionalCharge> DocumentAdditionalCharges { get; set; } = new HashSet<DocumentAdditionalCharge>();
    }
}
