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

        public Guid ProductId { get; set; } //Do not Add navigation property - Circular Reference

        [StringLength(255)]
        public string? Notes { get; set; }

        public DateTime? ProdDate { get; set; } //Production Date

        public DateTime? ExpDate { get; set; } //Expiration Date

        public Guid SupplierId { get; set; } //Do not Add navigation property - Circular Reference

        public int RemainingQty { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        public ICollection<DocumentProductLotQuantity> DocumentProductLotsQuantities { get; set; } = new HashSet<DocumentProductLotQuantity>();

    }
}
