using Am.Testing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Entities
{
    [Table("author", Schema = "public")]
    public class Author : BaseTimingEntity
    {
        [Key]
        public long Id { get; set; }

        public string FullName { get; set; } = "";
        
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string? Biography { get; set; }

        public string? Nationality { get; set; }

        public string? Photo { get; set; }

        public int? BirthYear { get; set; }

        public string Initials { get => $"{FirstName[..1]}{LastName[..1]}"; }
    }
}
