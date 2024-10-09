using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class LogDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }
        public DateTime LogDateTime { get; set; }

        public string LogName { get; set; }

        public LogTypeEnum LogType { get; set; }

        public LogOriginEnum LogOrigin { get; set; }

        public Guid UserAdded {  get; set; }
        
        public Guid UserAddedName { get; set; }

        public DateTime DateAdded { get; set; }
        public string AddedDateTimeFormatted { get; set; }
        public string LogTypeName { get; set; }
        public string LogOriginName { get; set; }
    }
}
