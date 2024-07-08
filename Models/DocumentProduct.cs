using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_documentproducts")]
    public class DocumentProduct:BaseModel
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

        [Precision(18,2)]
        public virtual decimal Price { get; set; }

        [Precision(18, 2)]
        public virtual decimal VatAmount {  get; set; }

        public virtual int Quantity { get; set;}

        [Precision(18, 2)]
        public virtual decimal TotalVatAmount { get; set; }

        [Precision(18, 2)]
        public virtual decimal TotalPrice { get; set; }

        public virtual Guid? ProductSizeId { get; set;}

        public virtual ProductSize? ProductSize { get; set; }


    }
}
