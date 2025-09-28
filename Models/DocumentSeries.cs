using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("dn_document_series")]
    public class DocumentSeries : BaseModel
    {
        public DocumentSeries()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
                
        [StringLength(255)]
        public string? Notes { get; set; }

        [StringLength(10)]
        public string Abbreviation { get; set; }

        [StringLength(10)]
        public string? Prefix { get; set; }

        [StringLength(10)]
        public string? Suffix { get; set; }

        [StringLength(10)]
        public int CurrentNumber { get; set; }

        public bool AllowManualNumbering { get; set; }
        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }

        public Guid DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }

    }
}
