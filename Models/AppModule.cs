﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataNex.Model.Models
{
    [Table("datanex_appmodules")]
    public class AppModule : BaseModel
    {
        public AppModule()
        {
            Id = Guid.NewGuid();

        }
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }



    }
}
