using DataNex.Model.Enums;

namespace DataNex.Model.Dtos
{
    public class AppPermissionDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public AppEntityEnum AppEntity { get; set; }

        public Guid? MasterEntityId { get; set; }
        public string? MasterEntityDescr { get; set; }

        public Guid CompanyId { get; set; }

    }
}
