using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class LotSettingsDto
    {
        public Guid Id { get; set; }

        public LotStrategyEnum LotStrategy { get; set; }

        public Guid CompanyId { get; set; }
    }
}
