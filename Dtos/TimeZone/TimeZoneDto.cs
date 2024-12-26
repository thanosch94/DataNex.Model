using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos.TimeZone
{
    public class TimeZoneDto
    {
        public string timeZone { get; set; }
        public DateTime currentLocalTime { get; set; }
        public UtcOffsetDto currentUtcOffset { get; set; }
        public UtcOffsetDto standardUtcOffset { get; set; }
        public bool hasDayLightSaving { get; set; }
        public bool isDayLightSavingActive { get; set; }
        public object dstInterval { get; set; }
    }
}
