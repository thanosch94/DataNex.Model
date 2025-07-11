using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("cntor_datasources")]

    public class CntorDatasource:BaseModel
    {
        public CntorDatasource()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }

        public string? Icon {  get; set; }
        public string? IconColor { get; set; }

        public bool HasCustomImage { get; set; }

        public string? CustomImagePath { get; set; }
        public int? CustomImageWidth { get; set; }

        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
        public ICollection<CntorDatasourceEntity> CntorDatasourceEntities { get; set; } = new HashSet<CntorDatasourceEntity>();

    }
}
