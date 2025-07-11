
namespace DataNex.Model.Dtos.Woocommerce
{
    public class ShippingLineDto
    {
        public int id { get; set; }
        public string method_title { get; set; }
        public string method_id { get; set; }
        public string total { get; set; }
        public string total_tax { get; set; }
        public List<TaxLineDto> taxes { get; set; }
        public List<MetaDataDto> meta_data { get; set; }
    }
}
