using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{

    [Table("datanex_user_permissions")]
    public class UserAppPermission : BaseModel
    {
        public UserAppPermission()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public Guid? AppPermissionId { get; set; }   
        public AppPermission? AppPermission { get; set; }
        
        public Guid? UserId { get; set; }

        public User? User { get; set; }

        public Guid? CompanyId { get; set; }

        public Company? Company { get; set; }

    }
}