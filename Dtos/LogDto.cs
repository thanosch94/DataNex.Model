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
        public int Guid { get; set; }
        public DateTime LogDateTime { get; set; }

        public string LogName { get; set; }

        public LogTypeEnum LogType { get; set; }

        public LogOriginEnum LogOrigin { get; set; }

        public Guid UserAdded {  get; set; }
        
        public Guid UserAddedName { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
