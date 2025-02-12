using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ApiResponseDto
    {
        public Object? Result { get; set; }
        public Object? Result2 { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }
        public string? ExceptionMessage { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
