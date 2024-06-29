using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class WooConnectionsDataDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public RequestTypeEnum RequestType { get; set; }

        public string Endpoint { get; set; }

        public WooEntityEnum WooEntity { get; set; }

    }
}
