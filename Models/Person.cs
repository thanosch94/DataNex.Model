using System.ComponentModel.DataAnnotations;

namespace DataNex.Model.Models
{
    public class Person : BaseModel
    {
        [StringLength(255)]
        public virtual string Name { get; set; }
        public virtual string? Notes { get; set; }

        public virtual string? Address { get; set; }

        [StringLength(255)]
        public virtual string? Region { get; set; }

        [StringLength(10)]
        public virtual string? PostalCode { get; set; }

        [StringLength(100)]
        public virtual string? City { get; set; }

        [StringLength(50)]
        public virtual string? Country { get; set; }

        [StringLength(20)]
        public virtual string? Phone1 { get; set; }

        [StringLength(20)]
        public virtual string? Phone2 { get; set; }

        [StringLength(100)]
        public virtual string? Email { get; set; }

        [StringLength(255)]
        public virtual string? CompanyName { get; set; }

        [StringLength(255)]
        public virtual string? Occupation { get; set; }

        public virtual int? VatNumber { get; set; }

        [StringLength(50)]
        public virtual string? TaxOffice { get; set; }
        public string? UserText1 { get; set; }
        public string? UserText2 { get; set; }
        public string? UserText3 { get; set; }
        public string? UserText4 { get; set; }
        public long? UserNumber1 { get; set; }
        public long? UserNumber2 { get; set; }
        public long? UserNumber3 { get; set; }
        public long? UserNumber4 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public virtual Guid? CompanyId { get; set; }

    }
}
