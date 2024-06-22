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
        public virtual Guid Id { get; set; }

        public DateTimeOffset DocumentDateTime { get; set; }

        public virtual Guid DocumentTypeId { get; set; }

        public virtual DocumentType DocumentType { get; set; }

        public virtual int DocumentNumber { get; set; }

        public Guid? DocumentStatusId { get; set; }

        public Status? DocumentStatus { get; set; }

        public virtual Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Precision(18, 2)]
        public virtual decimal? DocumentTotal { get; set; }

        [StringLength(255)]
        public virtual string? ShippingAddress { get; set; }

        [StringLength(50)]
        public virtual string? ShippingRegion { get; set; }

        public virtual int? ShippingPostalCode { get; set; }

        [StringLength(50)]
        public virtual string? ShippingCity { get; set; }

        [StringLength(50)]
        public virtual string? ShippingCountry { get; set; }

        public virtual long? ShippingPhone1 { get; set; }

        public virtual long? ShippingPhone2 { get; set; }

        [StringLength(255)]
        public virtual string? ShippingEmail { get; set; }

        public virtual string? UserText1 { get; set; }
        public virtual string? UserText2 { get; set; }
        public virtual string? UserText3 { get; set; }
        public virtual string? UserText4 { get; set; }
        public virtual long? UserNumber1 { get; set; }
        public virtual long? UserNumber2 { get; set; }
        public virtual long? UserNumber3 { get; set; }
        public virtual long? UserNumber4 { get; set; }
        public virtual DateTime? UserDate1 { get; set; }
        public virtual DateTime? UserDate2 { get; set; }
        public virtual DateTime? UserDate3 { get; set; }
        public virtual DateTime? UserDate4 { get; set; }
        public virtual ICollection<DocumentProduct> DocumentProducts { get; set; } = new HashSet<DocumentProduct>();
        public virtual ICollection<DocumentAdditionalCharge> DocumentAdditionalCharges { get; set; } = new HashSet<DocumentAdditionalCharge>();

    }
}
