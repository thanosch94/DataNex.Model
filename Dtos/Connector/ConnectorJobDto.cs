using DataNex.Model.Enums;
using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.Connector
{
    public class ConnectorJobDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public string Name { get; set; }

        public string? Icon { get; set; }

        public string? Description { get; set; }

        public ConnectorJobTypeEnum JobType { get; set; }

        public Guid DataSourceId { get; set; }

        public Guid? WooConnectionDataSourceId { get; set; }
        public Guid? CompanyId { get; set; }

    }
}
