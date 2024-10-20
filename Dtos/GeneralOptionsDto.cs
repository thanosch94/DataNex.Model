using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class GeneralOptionsDto
    {
        public Guid Id { get; set; }

        public bool LotsEnabled { get; set; }

        public Guid CompanyId { get; set; }

    }
}
