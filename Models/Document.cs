using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DataNex.Model.Models
{
    [Table("datanex_documents")]
    public class Document
    {
        public Document()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }

        public virtual Guid DocumentTypeId { get; set; }

        public virtual DocumentType DocumentType { get; set; }

        public virtual int DocumentNumber { get; set; }

        public virtual Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Precision(18, 2)]
        public virtual decimal? DocumentTotal { get; set; }

    }
}
