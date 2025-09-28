using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentSeriesDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Notes { get; set; }

        public string Abbreviation { get; set; }

        public string? Prefix { get; set; }

        public string? Suffix { get; set; }

        public int CurrentNumber { get; set; }

        public bool AllowManualNumbering { get; set; }
        public Guid? CompanyId { get; set; }

        public Guid DocumentTypeId { get; set; }

        public bool IsActive { get; set; }
    }
}
