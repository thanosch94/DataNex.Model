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

        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }
        
        public Document Document { get; set; }

        public Guid ProductId { get; set;}

        public Product Product { get; set;}

        [Precision(18,2)]
        public decimal Price { get; set; }

        [Precision(18, 2)]
        public decimal VatAmount {  get; set; }

        public int Quantity { get; set;}

        [Precision(18, 2)]
        public decimal TotalVatAmount { get; set; }

        [Precision(18, 2)]
        public decimal TotalPrice { get; set; }

        public Guid? ProductSizeId { get; set;}

        public ProductSize? ProductSize { get; set; }

        public ICollection<DocumentProductLotQuantity> DocumentProductLotsQuantities { get; set; }


        

    }
}
