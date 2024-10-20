using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class LotDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber {  get; set; } 

        public string? Code { get; set; }

        public string Name { get; set; }

        public string? Notes { get; set; }

        public DateTime? ProdDate { get; set; } //Production Date

        public DateTime? ExpDate { get; set; } //Expiration Date

        public Guid CompanyId { get; set; }
    }
}
