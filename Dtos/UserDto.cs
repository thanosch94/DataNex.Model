using DataNex.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public int? SerialNumber { get; set; }

        public string? Code { get; set; }

        public string Name { get; set; }

        public string? Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string PasswordHash { get; set; }


        public UserRolesEnum UserRole { get; set; }

        public Guid? CompanyId { get; set; }
        public string Token { get; set; }
        public CompanyDto? Company { get; set; }
    }
}
