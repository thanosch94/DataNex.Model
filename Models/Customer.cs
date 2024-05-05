using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_customers")]
    public class Customer:BaseModel
    {
        public Customer()
        {
            Id = Guid.NewGuid();    
        }
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }


        public virtual string? Address { get; set; }

        public virtual string? Region { get; set; }

        public virtual string? PostalCode { get; set; }

        public virtual string? City { get; set; }

        public virtual string? Country { get; set; }

        public virtual long? Phone1 { get; set; }

        public virtual long? Phone2 { get; set; }

        public virtual string? Email { get; set;}

        public virtual int? VatNumber { get; set; }

        public virtual string? TaxOffice { get; set; }

        public virtual ICollection<Document> Documnents { get; set; } = new HashSet<Document>();


    }

}
