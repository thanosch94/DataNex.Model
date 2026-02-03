using DataNex.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataNex.Model.Models
{
    [Table("datanex_documents")]
    public class Document : BaseModel
    {
        public Document()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public DateTimeOffset DocumentDateTime { get; set; }

        public Guid DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
        public Guid DocumentSeriesId { get; set; }
        public DocumentSeries DocumentSeries { get; set; }

        public int DocumentNumber { get; set; }

        [StringLength(20)]
        public string DocumentCode { get; set; }

        public Guid? DocumentStatusId { get; set; }

        public Status? DocumentStatus { get; set; }

        public Guid? CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public Guid? SupplierId { get; set; }

        public Supplier? Supplier { get; set; }

        public Guid? WarehouseId { get; set; }

        public WareHouse? Warehouse { get; set; }


        [Precision(18, 2)]
        public decimal? DocumentTotal { get; set; }

        [StringLength(255)]
        public string? ShippingAddress { get; set; }

        [StringLength(50)]
        public string? ShippingRegion { get; set; }

        public string? ShippingPostalCode { get; set; }

        [StringLength(50)]
        public string? ShippingCity { get; set; }

        [StringLength(50)]
        public string? ShippingCountry { get; set; }

        public string? ShippingPhone1 { get; set; }

        public string? ShippingPhone2 { get; set; }

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
        public virtual Guid? CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public ICollection<DocumentProduct> DocumentProducts { get; set; } = new HashSet<DocumentProduct>();
        public ICollection<DocumentAdditionalCharge> DocumentAdditionalCharges { get; set; } = new HashSet<DocumentAdditionalCharge>();
        public Guid VatClassId { get; set; }

        public VatClass VatClass { get; set; }

        public Guid? PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public Guid? ShippingMethodId { get; set; }
        public ShippingMethod? ShippingMethod { get; set; }

        public TransformationStatusEnum TransfromationStatus { get; set; }

        public string? SourceDocIds { get; set; }

        public string? TargetDocIds { get; set; }


        [NotMapped]
        public List<Guid>? SourceDocIdsList
        {
            get => string.IsNullOrEmpty(SourceDocIds)
                ? new List<Guid>()
                : SourceDocIds.Split(',')
                    .Select(x => Guid.Parse(x))
                    .ToList();

            set => SourceDocIds = value == null || !value.Any()
                ? null
                : string.Join(",", value);
        }

        [NotMapped]
        public List<Guid>? TargetDocIdsList
        {
            get => string.IsNullOrEmpty(TargetDocIds)
                ? new List<Guid>()
                : TargetDocIds.Split(',')
                    .Select(x => Guid.Parse(x))
                    .ToList();

            set => TargetDocIds = value == null || !value.Any()
                ? null
                : string.Join(",", value);
        }
    }
}
