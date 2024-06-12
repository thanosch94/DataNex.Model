using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.Woocommerce
{
    public class WooLinksDto
    {
        public List<WooSelfDto> self { get; set; }
        public List<WooCollectionDto> collection { get; set; }

    }
}
