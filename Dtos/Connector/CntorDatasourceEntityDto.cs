namespace DataNex.Model.Dtos.Connector
{
    public class CntorDatasourceEntityDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Icon { get; set; }
        public string? IconColor { get; set; }

        public Guid CntorDatasourceId { get; set; }

        public Guid? CompanyId { get; set; }
    }
}
