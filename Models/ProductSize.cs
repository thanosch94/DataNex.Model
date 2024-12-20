﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_product_sizes")]
    public class ProductSize:BaseModel
    {
        public ProductSize()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        [StringLength(50)]
        public virtual string Name { get; set; }

        [StringLength(10)]
        public virtual string? Abbreviation { get; set; }

        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }

        public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; } = new HashSet<ProductBarcode>();

    }
}
