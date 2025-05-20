using DataNex.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_permissions")]
    public class AppPermission : BaseModel
    {
        public AppPermission()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Key { get; set; }

        public AppEntityEnum AppEntity { get; set; }
        public Guid? MasterEntityId { get; set; }

        public string? MasterEntityDescr { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<UserAppPermission> UserAppPermissions { get; set; } = new HashSet<UserAppPermission>();

    }
}
