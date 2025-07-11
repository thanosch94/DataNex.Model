using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("cntor_datasource_entities")]
    public class CntorDatasourceEntity : BaseModel
    {
        public CntorDatasourceEntity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        public string? Icon { get; set; }
        public string? IconColor { get; set; }

        public Guid CntorDatasourceId { get; set; }

        public CntorDatasource CntorDatasource { get; set; }

        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
