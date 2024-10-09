using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ConnectorParametersDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public Guid? CompanyId { get; set; }

        public string? WooBaseUrl { get; set; }

        public string? WooConsumerKey { get; set; }

        public string? WooConsumerSecret { get; set; }
    }
}
