using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_documentproducts_lots_quantities")]

    public class DocumentProductLotQuantity:BaseModel
    {
        public DocumentProductLotQuantity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public Guid DocumentProductId { get; set; }

        public DocumentProduct DocumentProduct { get; set; }

        public Guid LotId { get; set; }

        public Lot Lot { get; set; }

        public int Quantity { get; set; }


    }
}
