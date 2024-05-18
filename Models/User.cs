using DataNex.Model.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{

    [Table("AspNetUsers")]
    public class User:IdentityUser<Guid>
    {
        public string Name { get; set; }
        public virtual bool IsActive { get; set; } = true;

        public virtual bool IsDeleted { get; set; } = false;

        public virtual DateTime DateAdded { get; set; } = DateTime.Now;

        public virtual Guid UserAdded { get; set; }

        public virtual DateTime? DateUpdated { get; set; }

        public virtual Guid? UserUpdated { get; set; }


        public virtual UserRolesEnum UserRole { get; set; }

        public virtual Guid? CompanyId { get; set; }    
    }
}
