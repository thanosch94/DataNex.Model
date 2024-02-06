using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_documentproducts")]
    public class DocumentProduct
    {

        public DocumentProduct()
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual Guid DocumentId { get; set; }
        
        public virtual Document Document { get; set; }

        public virtual Guid ProductId { get; set;}

        public virtual Product Product { get; set;}

        public virtual int ProductQuantity { get; set;}

        public virtual Guid? ProductSizeId { get; set;}

        public virtual ProductSize? ProductSize { get; set; }


    }
}
