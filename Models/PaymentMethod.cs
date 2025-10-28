using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("dn_payment_methods")]
    public class PaymentMethod : BaseModel
    {
        public PaymentMethod()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string? Notes { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Document> Documents { get; set; } = new HashSet<Document>();

    }
}
