using DataNex.Model.Enums;
using DataNex.Model.Models;

namespace DataNex.Model.Dtos
{
    public class WorkItemDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
        public Guid? MasterTaskId { get; set; }
        public Guid? StatusId { get; set; }
        public Guid? AssigneeId { get; set; }
        public Guid? WorkItemTypeId { get; set; }

        public WorkItemCategoryEnum WorkItemCategory {  get; set; }
        public Guid? SprintId { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid? CompanyId { get; set; }

    }
}
