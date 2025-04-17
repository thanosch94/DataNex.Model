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
    [Table("datanex_statuses")]

    public class Status:BaseModel
    {
        public Status()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public StatusTypeEnum StatusType { get; set; }

        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }

        public ICollection<Document> Documnents { get; set; } = new HashSet<Document>();
        public ICollection<WorkItem> WorkItems { get; set; } = new HashSet<WorkItem>();
    }
}
