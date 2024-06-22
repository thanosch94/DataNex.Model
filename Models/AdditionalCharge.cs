using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_additional_charges")]
    public class AdditionalCharge:BaseModel
    {
        public AdditionalCharge()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<DocumentAdditionalCharge> DocumentAdditionalCharges { get; set; } = new HashSet<DocumentAdditionalCharge>();

    }
}
