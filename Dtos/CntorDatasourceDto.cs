using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class CntorDatasourceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public string? IconColor { get; set; }
        public bool HasCustomImage { get; set; }
        public string? CustomImagePath { get; set; }
        public int? CustomImageWidth { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
