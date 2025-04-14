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

        public string Token { get; set; }
        public Guid? UserRoleId { get; set; } 

        public byte[]? Image { get; set; }

        public string? Country { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Address { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Notes { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Occupation { get; set; }
        public string? FacebookUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedInUrl { get; set; }

        public Guid? CompanyId { get; set; }
        public bool IsActive { get; set; }
  
        public CompanyDto? Company { get; set; }
        public bool IsPasswordSet { get; set; }
    }
}
