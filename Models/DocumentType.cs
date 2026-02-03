using DataNex.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_documenttypes")]
    public class DocumentType : BaseModel
    {

        public DocumentType()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Abbreviation { get; set; }

        [StringLength(50)]
        public string? Description { get; set; }

        public DocumentTypeGroupEnum DocumentTypeGroup { get; set; }

        public DocTypeAffectBehaviorEnum PersonBalanceAffectBehavior { get; set; }

        public DocTypeAffectBehaviorEnum WareHouseAffectBehavior { get; set; }
        public PriceTypesEnum UsesPrices { get; set; }
        public bool AutoIncrementCodeEnabled { get; set; }
        public Guid? CancellationDocTypeId { get; set; }
        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }

        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();
        public ICollection<DocumentSeries> DocumentSeries { get; set; } = new HashSet<DocumentSeries>();

    }
}
