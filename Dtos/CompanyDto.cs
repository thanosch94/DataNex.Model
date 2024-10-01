using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class CompanyDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
    }
}
