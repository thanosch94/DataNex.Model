using DataNex.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_workitem_types")]
    public class WorkItemType : BaseModel
    {
        public WorkItemType()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string? Icon { get; set; }
        public string? IconColor { get; set; }

        public WorkItemCategoryEnum Category { get; set; } //It refers to the entity (Task, Project)

        public bool IsDefault { get; set; }
        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }
        public ICollection<WorkItem> WorkItems { get; set; } = new HashSet<WorkItem>();

        

    }
}
