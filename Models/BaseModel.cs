using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    public class BaseModel
    {
        public virtual bool IsActive { get; set; } = true;

        public virtual bool IsDeleted { get; set; } = false;

        public virtual DateTime DateAdded { get; set; } = DateTime.Now;

        public virtual Guid? UserAdded { get; set; } 

        public virtual DateTime? DateUpdated { get; set;}

        public virtual Guid? UserUpdated { get; set; }

    }
}
