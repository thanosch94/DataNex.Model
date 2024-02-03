using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    public class DocumentType
    {

        public DocumentType()
        {
            Id= Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<Document> Documnents { get; set; } = new HashSet<Document>();

    }
}
