using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_companyappmodules")]
    public class CompanyAppModule:BaseModel
    {
        public CompanyAppModule()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid AppModuleId { get; set; }
        public AppModule AppModule { get; set; }



    }
}
