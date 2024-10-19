using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_warehouses")]
    public class WareHouse:BaseModel
    {
        public WareHouse()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }
    }
}
