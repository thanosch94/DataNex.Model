using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class AccountPayableDto
    {
        public Guid SupplierId { get; set; }

        public string SupplierName { get; set; }

        public decimal? PayableTotal {  get; set; }

    }
}
