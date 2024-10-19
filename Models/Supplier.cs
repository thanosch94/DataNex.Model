using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_suppliers")]
    public class Supplier:Person
    {
        public Supplier() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public virtual Guid? CompanyId { get; set; }

        public virtual Company? Company { get; set; }

        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();


    }
}
