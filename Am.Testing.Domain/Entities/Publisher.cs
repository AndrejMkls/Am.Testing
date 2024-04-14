using Am.Testing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Entities
{
    public class Publisher : BaseTimingEntity
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Website { get; set; }

        public string? PublisherType { get; set; }

        public int YearFounded { get; set; }

        public string? Notes { get; set; }
    }
}
