using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class AdditionalChargeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
