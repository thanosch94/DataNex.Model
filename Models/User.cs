using DataNex.Model.Dtos;
using DataNex.Model.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataNex.Model.Models
{

    [Table("AspNetUsers")]
    public class User:IdentityUser<Guid>
    {
        public int? SerialNumber { get; set; }

        [StringLength(25)]
        public string? Code { get; set; }

        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public DateTime DateAdded { get; set; } = DateTime.Now;

        public Guid UserAdded { get; set; }

        public DateTime? DateUpdated { get; set; }

        public Guid? UserUpdated { get; set; }

        //public Guid? UserRole { get; set; } //User Roles are saved in another table

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

        public Company? Company { get; set; }

        public ICollection<UserAppPermission> UserAppPermissions { get; set; } = new HashSet<UserAppPermission>();

        //public ICollection<WorkItem> WorkItems { get; set; } = new HashSet<WorkItem>(); 
        //TODO Check why the above on insert new workitem throws object cycle error

    }
}
