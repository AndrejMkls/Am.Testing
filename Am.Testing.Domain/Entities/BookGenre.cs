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
    [Table("book_genre", Schema = "public")]
    public class BookGenre : BaseTimingEntity, ICloneable
    {
        [Key]
        public long Id { get; set; }

        [Column("genre_id")]
        public long GenreId { get; set; }

        [ForeignKey(nameof(GenreId))]
        public Genre? Genre { get; set; }

        [Column("book_id")]
        public long BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book? Book { get; set; } 

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
