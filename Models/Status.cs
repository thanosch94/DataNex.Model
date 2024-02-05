using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_statuses")]

    public class Status
    {
        public Status()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }

        [StringLength(50)]
        public virtual string Name { get; set; }

        public virtual ICollection<Document> Documnents { get; set; } = new HashSet<Document>();

    }
}
