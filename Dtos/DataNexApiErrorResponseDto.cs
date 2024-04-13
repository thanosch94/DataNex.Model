using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class DataNexApiErrorResponseDto
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public string Title { get; set; }
        public string InnerExceptionMessage { get; set; }
    }
}
