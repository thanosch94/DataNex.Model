using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_brands")]
    public class Brand:BaseModel
    {
        public Brand()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        [StringLength(50)]
        public virtual string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();


    }
}
