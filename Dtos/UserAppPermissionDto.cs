using DataNex.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class UserAppPermissionDto
    {
        public Guid Id { get; set; }

        public Guid? AppPermissionId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? CompanyId { get; set; }

    }
}
