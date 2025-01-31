using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public CategoryTypeEnum CategoryType { get; set; }
        public byte CategoryLevel { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
