﻿using Microsoft.EntityFrameworkCore;
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
    public class Product:BaseModel
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual string? Sku { get; set; }

        [StringLength(255)]
        public virtual string Name { get; set; }

        [StringLength(255)]
        public virtual string? Barcode { get; set; }

        public virtual string? Description { get; set; }

        public virtual string? ImagePath { get; set; }

        public Guid VatClassId { get; set; }

        public VatClass VatClass { get; set; }

        [Precision(18,2)]
        public virtual decimal? RetailPrice { get; set; }

        [Precision(18, 2)]
        public virtual decimal? WholesalePrice { get; set; }


        public virtual Guid? BrandId { get; set; }

        public virtual Brand? Brand { get; set; }
        public Guid? Category1Id { get; set; }
        public Guid? Category2Id { get; set; }
        public Guid? Category3Id { get; set; }

        public virtual Guid? CompanyId { get; set; }

        public virtual Company? Company { get; set; }

        public virtual ICollection<DocumentProduct> DocumentProducts { get; set; } = new HashSet<DocumentProduct>();
        public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; } = new HashSet<ProductBarcode>();


    }
}
