using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class CompanyAppModuleDto
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid AppModuleId { get; set; }

    }
}
