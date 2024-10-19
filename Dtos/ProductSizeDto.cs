using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ProductSizeDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public string Name { get; set; }

        public string? Abbreviation { get; set; }
        public Guid? CompanyId { get; set; }

        //public virtual ICollection<DocumentProduct> DocumentProducts { get; set; } = new HashSet<DocumentProduct>();

    }
}
