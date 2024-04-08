using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.OpenAIDtos
{
    public class OpenAIResponseDto
    {
        public string id { get; set; }
        public string @object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public List<OpenAIChoiceDto> choices { get; set; }
        public OpenAIUsageDto usage { get; set; }
        public object system_fingerprint { get; set; }
    }
}
