using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_clients")]
    public class Client:BaseModel
    {
        public Client()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        [Required]
        public string Address { get; set; }

        [StringLength(255)]
        public string? Region { get; set; }

        [StringLength(15)]
        [Required]
        public string PostalCode { get; set; }
        
        [StringLength(100)]
        [Required]
        public string City { get; set; }
        
        [StringLength(100)]
        [Required]
        public string Country { get; set; }
        
        [StringLength(25)]
        [Required]
        public string Phone1 { get; set; }
        
        [StringLength(25)]
        public string? Phone2 { get; set; }

        [StringLength(100)]
        [Required]
        public string Email { get; set; }

    }
}
