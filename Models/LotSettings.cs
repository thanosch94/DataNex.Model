using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_lots_settings")]
    public class LotSettings:BaseModel
    {
        public LotSettings()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public LotStrategyEnum LotStrategy { get; set; }

        public LotStrategyApplyFieldEnum LotStrategyApplyField { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
