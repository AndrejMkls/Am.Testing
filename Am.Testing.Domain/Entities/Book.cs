using Am.Testing.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Entities
{
    //Here's a list of information commonly stored about books:

    //Title: The title of the book.
    //Author(s): The name(s) of the author(s) or contributor(s).
    //ISBN(International Standard Book Number) : A unique identifier for the book.
    //Publisher: The name of the publisher.
    //Publication Date: The date when the book was published.
    //Edition: If applicable, which edition of the book it is.
    //Genre/Category: The genre or category the book belongs to (e.g., fiction, non-fiction, mystery, science fiction).
    //Synopsis/Summary: A brief overview or summary of the book's content.
    //Language: The language in which the book is written.
    //Page Count: The number of pages in the book.
    //Dimensions: Physical dimensions of the book (height, width, thickness).
    //Cover Type: Whether the book is hardcover, paperback, or other.
    //Price: The price of the book, either the retail price or the price paid.
    //Condition: The condition of the book (new, used, etc.).
    //Location: Where the book is stored or shelved.
    //Keywords/Tags: Relevant keywords or tags for easy search and categorization.
    //Reviews/Ratings: User or critic reviews and ratings.
    //Associated Media: If applicable, any associated media like CDs, DVDs, or online resources.
    //Series Information: If the book is part of a series, information about its position in the series.
    //Related Books: Other books by the same author or books on similar topics.
    //Availability: Whether the book is currently available or out of stock.
    //Notes: Any additional notes or remarks about the book.

    [Table("book", Schema = "public")]
    public class Book : BaseTimingEntity
    {
        [Key]
        public long Id { get; set; }    

        public required string Title { get; set; }

        public string? ISBN { get; set; }

        public ICollection<Author> Authors {  get; set; } = new List<Author>();

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        public long PublisherId { get; set; }

        public Publisher? Publisher { get; set; }

        public DateTime PublicationDate { get; set; }

        public string? Edition { get; set; }

        public string? Summary { get; set; }

        public required string Language { get; set; }

        public int PageCount { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }   

        public double Thickness { get; set; }

        public long CoverTypeId { get; set; }

        public CoverType? CoverType { get; set; }



    }
}
