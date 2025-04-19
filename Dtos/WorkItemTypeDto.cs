using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class WorkItemTypeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string? Icon { get; set; }
        public string? IconColor { get; set; }

        public bool IsDefault { get; set; }

        public WorkItemCategoryEnum Category { get; set; } //It refers to the entity (Task, Project)
        public Guid? CompanyId { get; set; }
    }
}
