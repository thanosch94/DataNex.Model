using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_documenttypes")]
    public class DocumentType:BaseModel
    {

        public DocumentType()
        {
            Id= Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Abbreviation { get; set; }

        [StringLength(50)]
        public string? Description { get; set; }

        public DocumentTypeGroupEnum DocumentTypeGroup { get; set; }


        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();

    }
}
