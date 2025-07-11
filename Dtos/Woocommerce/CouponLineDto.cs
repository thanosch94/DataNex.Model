namespace DataNex.Model.Dtos.Woocommerce
{
    public class CouponLineDto
    {
        public int id { get; set; }
        public string code { get; set; }
        public string discoumt { get; set; }
        public string discount_tax { get; set; }
        public List<MetaDataDto> meta_data { get; set; }
    }
}
