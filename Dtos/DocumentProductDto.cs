using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentProductDto
    {
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }

        public Guid ProductId { get; set; }

        public int ProductQuantity { get; set; }

        public Guid? ProductSizeId { get; set; }

        public ProductSize? ProductSize { get; set; }
    }
}
