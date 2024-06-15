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
    public  class WooConnectionsData
    {
        public WooConnectionsData() 
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id {get; set;}

        [StringLength(50)]
        public virtual string Name { get; set;}

        public virtual RequestTypeEnum RequestType { get; set;} 

        public virtual string Endpoint { get; set;}



    }
}
