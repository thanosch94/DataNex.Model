using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_categories")]
    public class Category:BaseModel
    {
        public Category()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public CategoryTypeEnum CategoryType { get; set; }

        public byte CategoryLevel { get; set; }
        public Guid? CompanyId { get; set; }


    }
}
