using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_companies")]
    public class Company:BaseModel
    {
        public Company()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

    }
}
