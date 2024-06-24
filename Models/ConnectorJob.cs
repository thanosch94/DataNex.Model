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
    [Table("connector_jobs")]
    public class ConnectorJob:BaseModel
    {
        public ConnectorJob()
        {
            Id=Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        public ConnectorJobTypeEnum JobType { get; set; }

        public Guid DataSourceId { get; set; }

        public Guid? WooConnectionDataSourceId { get; set; }

        public WooConnectionsData? WooConnectionDataSource {  get; set; }
        public string? Icon { get; set; }
    }
}
