using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_users")]
    public class User:BaseModel
    {
        public User()
        {
            Id = Guid.NewGuid();    
        }
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string? Email { get; set; }

        public virtual string Username { get; set; }    

        public virtual string PasswordHash { get; set; }

        public virtual UserRolesEnum UserRole { get; set; }

        public virtual Guid? CompanyId { get; set; }    
    }
}
