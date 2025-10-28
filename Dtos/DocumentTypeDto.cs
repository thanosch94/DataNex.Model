using DataNex.Model.Enums;
using DataNex.Model.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentTypeDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public DocumentTypeGroupEnum  DocumentTypeGroup { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; }
        public Guid? CompanyId { get; set; }

        public DocTypeAffectBehaviorEnum PersonBalanceAffectBehavior { get; set; }

        public DocTypeAffectBehaviorEnum WareHouseAffectBehavior { get; set; }

        public List<DocumentSeriesDto> DocumentSeries { get; set; } 
        
    }
}
