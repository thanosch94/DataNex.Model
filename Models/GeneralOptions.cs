using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_general_options")]
    public class GeneralOptions:BaseModel
    {
        public GeneralOptions()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public bool LotsEnabled { get; set; }

        public Guid CompanyId {  get; set; }

        public Company Company { get; set; }
    }
}
