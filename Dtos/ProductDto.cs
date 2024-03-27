using DataNex.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Dtos
{
    public class ProductDto
    {

        public Guid Id { get; set; }

        public string? Sku { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public decimal? Price { get; set; }

        public Guid? BrandId { get; set; }
    }
}
