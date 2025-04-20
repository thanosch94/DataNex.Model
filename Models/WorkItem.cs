using DataNex.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_workitems")]
    public class WorkItem : BaseModel
    {
        public WorkItem()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }
        public Guid? MasterTaskId { get; set; }
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }
        public Guid? AssigneeId { get; set; }
        public User? Assignee { get; set; }
        public Guid? WorkItemTypeId { get; set; }
        public WorkItemType? WorkItemType { get; set; }
        public WorkItemPriorityEnum WorkItemPriority { get; set; }
        public WorkItemCategoryEnum WorkItemCategory { get; set; }
        public Guid? SprintId { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }

    }
}
