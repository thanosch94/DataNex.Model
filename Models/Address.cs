using DataNex.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("dn_addresses")]
    public class Address : BaseModel
    {
        public Address()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string? StreetNumber { get; set; }
        public string? PostalCode { get; set; }
        public string City { get; set; }
        public string? Country { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<CustomerAddress> CustomerAddresses { get; set; } = new HashSet<CustomerAddress>();

    }
}
