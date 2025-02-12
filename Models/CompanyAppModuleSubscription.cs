using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_companyappmodule_subscription")]

    public class CompanyAppModuleSubscription : BaseModel
    {
        public CompanyAppModuleSubscription()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        public Guid CompanyAppModuleId { get; set; }

        public CompanyAppModule CompanyAppModule { get; set; }

        public DateTime ActivationDate { get; set; }

        public DateTime ExpirationDate { get; set;}
    }
}
