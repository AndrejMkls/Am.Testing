using Am.Testing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Entities
{
    [Table("publisher", Schema = "public")]
    public class Publisher : BaseTimingEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }

        [Column("phone_number")]
        [StringLength(30)]
        public string? PhoneNumber { get; set; }

        [Column("website")]
        [StringLength(50)]
        public string? Website { get; set; }

        [Column("publisher_type")]
        [StringLength(50)]
        public string? PublisherType { get; set; }

        [Column("year_founded")]
        public int YearFounded { get; set; }

        [Column("notes")]
        public string? Notes { get; set; }
    }
}
