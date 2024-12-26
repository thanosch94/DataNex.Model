using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.TimeZone
{
    public class UtcOffsetDto
    {
        public long seconds { get; set; }
        public long milliseconds { get; set; }
        public long ticks { get; set; }
        public long nanoseconds { get; set; }
    }
}

