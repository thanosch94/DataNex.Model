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
    [Table("connector_wooconnectionsdata")]
    public  class WooConnectionsData:BaseModel
    {
        public WooConnectionsData() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id {get; set;}

        [StringLength(50)]
        public string Name { get; set;}

        public RequestTypeEnum RequestType { get; set;} 

        public string Endpoint { get; set;}

        public WooEntityEnum WooEntity { get; set;} 

        public ICollection<ConnectorJob> ConnectorJobs { get; set; } = new HashSet<ConnectorJob>();

        public Guid? CompanyId { get; set;}

        public Company? Company { get; set;}

    }
}
