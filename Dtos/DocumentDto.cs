using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentDto
    {
        public Guid Id { get; set; }

        public Guid DocumentTypeId { get; set; }

        public int DocumentNumber { get; set; }

        public Guid CustomerId { get; set; }

        public decimal? DocumentTotal { get; set; }  
    }
}
