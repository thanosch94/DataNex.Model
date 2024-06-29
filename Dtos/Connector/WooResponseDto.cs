using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.Connector
{
    public class WooResponseDto
    {
        public Guid? Id { get; set; }

        public bool Success {  get; set; }

        public HttpStatusCode StatusCode { get; set; }  

        public string? Message {  get; set; }

        public string? ExceptionMessage {  get; set; }

        public string? Response { get; set; }

    }
}
