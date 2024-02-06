using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_products")]
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual string? Sku { get; set; }

        [StringLength(255)]

        public virtual string Name { get; set; }

        public virtual string? Description { get; set; }

        public virtual byte[]? Image { get; set; }

        [Precision(18,2)]
        public virtual decimal? Price { get; set; }


        public virtual Guid? BrandId { get; set; }

        public virtual Brand? Brand { get; set; }

        public virtual ICollection<DocumentProduct> DocumentProducts { get; set; } = new HashSet<DocumentProduct>();


    }
}
