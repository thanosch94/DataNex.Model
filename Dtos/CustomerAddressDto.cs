using DataNex.Model.Enums;

namespace DataNex.Model.Dtos
{
    public class CustomerAddressDto
    {
        public Guid Id { get; set; }
        public AddressTypeEnum AddressType { get; set; }
        public Guid AddressId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CompanyId { get; set; }
    }
}
