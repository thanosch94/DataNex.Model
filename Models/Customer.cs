using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_customers")]
    public class Customer : Person
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }
        public virtual Guid? VatClassId { get; set; }
        public virtual VatClass? VatClass { get; set; }
        public virtual Guid? CompanyId { get; set; } //Refers to the Id of the app user company

        public virtual Company? Company { get; set; }

        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();
        public ICollection<CustomerAddress> CustomerAddresses { get; set; } = new HashSet<CustomerAddress>();


    }

}
