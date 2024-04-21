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
    [Table("book_author", Schema = "public")]
    public class BookAuthor : BaseTimingEntity, ICloneable
    {
        [Key]
        public long Id { get; set; }

        [Column("author_id")]
        [Required]
        public long AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author? Author { get; set; }

        [Column("book_id")]
        [Required]
        public long BookId { get; set; }

        [ForeignKey(nameof(BookId))]
        public Book? Book { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
