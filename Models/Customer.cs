using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_customers")]
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();    
        }
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }


        //Billing
        public virtual string? BAddress { get; set; }

        public virtual string? BRegion { get; set; }

        public virtual string? BPostalCode { get; set; }

        public virtual string? BCity { get; set; }

        public virtual string? BCountry { get; set; }

        public virtual int? BPhone1 { get; set; }

        public virtual int? BPhone2 { get; set; }

        public virtual string? BEmail { get; set;}


        //Shipping
        public virtual string? SAddress { get; set; }

        public virtual string? SRegion { get; set; }

        public virtual string? SPostalCode { get; set; }

        public virtual string? SCity { get; set; }

        public virtual string? SCountry { get; set; }

        public virtual int? SPhone1 { get; set; }

        public virtual int? SPhone2 { get; set; }

        public virtual string? SEmail { get; set; }


    }

}
