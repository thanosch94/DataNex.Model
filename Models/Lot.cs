using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_lots")]
    public class Lot:BaseModel
    {
        public Lot()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(255)]
        public string? Notes { get; set; }

        public DateTime? ProdDate { get; set; } //Production Date

        public DateTime? ExpDate { get; set; } //Expiration Date

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }


    }
}
