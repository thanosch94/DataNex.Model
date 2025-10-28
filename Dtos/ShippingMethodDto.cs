namespace DataNex.Model.Dtos
{
    public class ShippingMethodDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; }
        public Guid CompanyId { get; set; }
    }
}
