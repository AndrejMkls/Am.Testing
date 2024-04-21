using Am.Testing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.App.Seeding
{
    public class AuthorSeeding
    {
        private readonly IList<Author> _items;

        public IList<Author> Items { get => _items; }

        public AuthorSeeding() => _items =
            [
                new Author() {  FullName = "Stephen King",
                                FirstName = "Stephen",
                                LastName = "King",
                                Nationality = "americká",
                                BirthYear = 1947,
                                },

                new Author() {  FullName = "J. K. Rowling",
                                FirstName = "Joanne",
                                LastName = "Rowling",
                                Nationality = "anglická",
                                BirthYear = 1965,
                                },

                new Author() {  FullName = "George R. R. Martin",
                                FirstName = "George",
                                LastName = "Martin",
                                Nationality = "americká",
                                BirthYear = 1948,
                                },
            ];
    }
}
