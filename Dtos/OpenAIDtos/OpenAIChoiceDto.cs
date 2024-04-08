using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.OpenAIDtos
{
    public class OpenAIChoiceDto
    {
        public int index { get; set; }
        public OpenAIMessageDto message { get; set; }
        public object logprobs { get; set; }
        public string finish_reason { get; set; }
    }
}
