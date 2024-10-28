using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentProductLotQuantityDto
    {
        public Guid Id { get; set; }

        public Guid? DocumentProductId { get; set; }

        public Guid LotId { get; set; }

        public int Quantity { get; set; }
    }
}
