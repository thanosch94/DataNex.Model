﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual DateTime DateAdded { get; set; } = DateTime.Now;

        public virtual Guid? UserAdded { get; set; } 

        public virtual DateTime? DateUpdated { get; set;}

        public virtual Guid? UserUpdated { get; set; }

    }
}
