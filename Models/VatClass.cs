using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_vat_classes")]
    public class VatClass:BaseModel
    {
        public VatClass()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }
        
        [StringLength(10)]
        public string? Abbreviation { get; set; }

        public short Rate { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();

        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }

    }
}
