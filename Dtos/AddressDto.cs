using DataNex.Model.Enums;

namespace DataNex.Model.Dtos
{
    public class AddressDto
    { 
        public Guid Id { get; set; }
        public AddressTypeEnum AddressType { get; set; }
        public string Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? PostalCode { get; set; }
        public string City { get; set; }
        public string? Country { get; set; }
        public Guid CompanyId { get; set; }

    }
}
