﻿using Am.Testing.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Entities
{
    [Table("genre", Schema = "public")]
    public class Genre : BaseTimingEntity, ICloneable
    {
        [Key]
        public long Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
