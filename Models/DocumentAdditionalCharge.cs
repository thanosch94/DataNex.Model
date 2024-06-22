using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_document_additional_charges")]
    public class DocumentAdditionalCharge:BaseModel
    {
        public DocumentAdditionalCharge()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }

        public Document Document { get; set; }

        public Guid AdditionalChargeId { get; set; }
        public AdditionalCharge AdditionalCharge { get; set; }

        public decimal AdditionalChargeAmount {  get; set; } 
    }
}
