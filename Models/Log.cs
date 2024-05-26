using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_logs")]
    public class Log:BaseModel
    {
        public Log()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id {  get; set; }

        public string LogName {  get; set; }

        public LogTypeEnum LogType { get; set; }

        public LogTypeEnum LogOrigin { get; set; }

    }
}
