using Am.Testing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.App.Seeding
{
    public class PublisherSeeding
    {
        private readonly IList<Publisher> _items;

        public IList<Publisher> Items { get => _items; }

        public PublisherSeeding() => _items =
            [
                new Publisher() {   Name = "Ikar",
                                    Email = "ikar@ikar.sk",
                                    PhoneNumber = "02/49 104 333",
                                    Website = "https://www.ikar.sk/",
                                    YearFounded = 1990,
                                },

                new Publisher() {   Name = "Slovart",
                                    Email = "objednavky@slovart.sk",
                                    PhoneNumber = "+421/2/49 20 18 00",
                                    Website = "https://www.slovart.sk/",
                                    YearFounded = 1991,
                                },

                new Publisher() {   Name = "Tatran",
                                    Email = "info@slovtatran.sk",
                                    PhoneNumber = "02/5443 5849",
                                    Website = "https://www.slovtatran.sk/",
                                    YearFounded = 1947,
                                },

            ];
    }
}
