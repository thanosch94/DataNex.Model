using DataNex.Model.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("dn_customer_addresses")]
    public class CustomerAddress : BaseModel
    {
        public CustomerAddress()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public AddressTypeEnum AddressType { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }


    }
}
