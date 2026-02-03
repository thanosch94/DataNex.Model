using DataNex.Model.Models;

namespace DataNex.Model.Dtos
{
    public class DocTypeTransformationDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public Guid From { get; set; }
        public Guid To { get; set; }
        public Guid? SourceStatusId { get; set; }
        public Guid? TargetStatusId { get; set; }
        public Guid CompanyId { get; set; }
    }
}
