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
    [Table("cover_type", Schema = "public")]
    public class CoverType : BaseTimingEntity, ICloneable
    {
        [Key]
        public long Id { get; set; }

        public required string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
