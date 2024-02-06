﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNex.Model.Models
{
    [Table("datanex_documenttypes")]
    public class DocumentType
    {

        public DocumentType()
        {
            Id= Guid.NewGuid();
        }

        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<Document> Documnents { get; set; } = new HashSet<Document>();

    }
}
