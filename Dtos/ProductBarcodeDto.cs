using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ProductBarcodeDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public Guid ProductId { get; set; }

        public Guid? SizeId { get; set; }
        public Guid? VatClassId { get; set; }

        public string? Sku { get; set; }

        public string? Barcode { get; set; }
        public string? SizeName { get; set; }
        public string? ProductName { get; set; }
        public decimal? ProductRetailPrice { get; set; }

        public bool? IsEditable { get; set; }
    }
}
