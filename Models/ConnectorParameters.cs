using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("connector_parameters")]
    public class ConnectorParameters:BaseModel
    {
        public ConnectorParameters()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }

        public virtual Guid? CompanyId { get; set; }

        public virtual string? WooBaseUrl { get; set; }

        public virtual string? WooConsumerKey {  get; set; }

        public virtual string? WooConsumerSecret { get; set; }


    }
}
