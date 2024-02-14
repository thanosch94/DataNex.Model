using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{

    [Table("datanex_product_barcodes")]
    public class ProductBarcode
    {
        public ProductBarcode()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual Guid ProductId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Guid? SizeId { get; set; }

        public virtual ProductSize? Size { get; set;}

        public virtual long? Barcode {  get; set; }


    }
}
