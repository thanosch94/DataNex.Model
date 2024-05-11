using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ApiResponseDto
    {
        public Object? Result { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }




    }
}
