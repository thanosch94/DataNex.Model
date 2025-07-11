namespace DataNex.Model.Dtos.Woocommerce
{
    public class FeeLineDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tax_class { get; set; }
        public string tax_status { get; set; }
        public string total { get; set; }
        public string total_tax { get; set; }
        public List<TaxLineDto> taxes { get; set; }
        public List<MetaDataDto> meta_data { get; set; }
    }

}
