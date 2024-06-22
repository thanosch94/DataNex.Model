using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentAdditionalChargeDto
    {
        public Guid Id { get; set; }

        public Guid DocumentId { get; set; }

        public Guid AdditionalChargeId { get; set; }

        public decimal AdditionalChargeAmount { get; set; }
    }
}
