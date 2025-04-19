using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class StatusDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public string Name { get; set; }
        public string? Icon { get; set; }
        public string? IconColor { get; set; }
        public short? Order { get; set; }
        public bool IsDefault { get; set; }

        public StatusTypeEnum StatusType { get; set; }

        public Guid? CompanyId { get; set; }

    }
}
