using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    public class BaseModel
    {
        public int? SerialNumber { get; set; }

        [StringLength(25)]
        public string? Code { get; set; }

        public virtual bool IsActive { get; set; } = true;

        public virtual bool IsDeleted { get; set; } = false;

        public virtual bool IsSeeded { get; set; } = false;

        private DateTime _DateAdded;
        
        [BackingField((nameof(_DateAdded)))]
        public virtual DateTime DateAdded
        {
            get
            {
                return _DateAdded.AddHours(TimeZoneSettings.UserOffsetHours);
            }
            set
            {
                _DateAdded = DateTime.UtcNow;
            }
        }
        [NotMapped]
        public virtual DateTime LocalDateAdded {
            get
            {
                return _DateAdded.AddHours(TimeZoneSettings.UserOffsetHours);
            }
            set
            {
                _DateAdded = DateTime.UtcNow;
            }
        }
        public virtual Guid? UserAdded { get; set; } 

        public virtual DateTime? DateUpdated { get; set;}

        public virtual Guid? UserUpdated { get; set; }

    }
}
