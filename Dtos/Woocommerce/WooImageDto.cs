using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.Woocommerce
{
    public class WooImageDto
    {
        public int id { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_created_gmt { get; set; }
        public DateTime? date_modified { get; set; }
        public DateTime? date_modified_gmt { get; set; }
        public string? src { get; set; }
        public string? name { get; set; }
        public string? alt { get; set; }
    }
}
