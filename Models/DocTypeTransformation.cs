using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("dn_doctypes_transformations")]
    public class DocTypeTransformation:BaseModel
    {
        public DocTypeTransformation()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid From { get; set; }
        public Guid To { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
