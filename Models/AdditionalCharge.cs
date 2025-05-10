using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_additional_charges")]
    public class AdditionalCharge : BaseModel
    {
        public AdditionalCharge()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public virtual Guid? CompanyId { get; set; }
        public virtual Company? Company { get; set; }

        public virtual ICollection<DocumentAdditionalCharge> DocumentAdditionalCharges { get; set; } = new HashSet<DocumentAdditionalCharge>();

    }
}
