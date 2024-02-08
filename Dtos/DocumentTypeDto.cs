using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DocumentTypeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }


    }
}
