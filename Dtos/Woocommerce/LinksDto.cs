
namespace DataNex.Model.Dtos.Woocommerce
{
    public class LinksDto
    {
        public List<LinkDto> self { get; set; }
        public List<LinkDto> collection { get; set; }

    }

    public class LinkDto
    {
        public string href { get; set; }
    }
}
