namespace DataNex.Model.Dtos.Woocommerce
{
    public class TaxLineDto
    {
        public int id { get; set; }
        public string rate_code { get; set; }
        public int rate_id { get; set; }
        public string label { get; set; }
        public bool compound { get; set; }
        public string tax_total { get; set; }
        public string shipping_tax_total { get; set; }
        public List<MetaDataDto> meta_data { get; set; }
    }
}
