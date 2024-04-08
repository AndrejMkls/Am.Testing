using Am.Testing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.App.Seeding
{
    public class GenreSeeding
    {
        private readonly IList<Genre> _items;

        public IList<Genre> Items { get => _items; }

        public GenreSeeding() => _items =
            [
                new Genre() { Name = "Autobiografia"},
                new Genre() { Name = "Bájka"},
                new Genre() { Name = "Biografia"},
                new Genre() { Name = "Denník"},
                new Genre() { Name = "Esej"},
                new Genre() { Name = "Dobrodružný román"},
                new Genre() { Name = "Fantasy"},
                new Genre() { Name = "Filozofický román"},
                new Genre() { Name = "Gotický román"},
                new Genre() { Name = "Historický román"},
                new Genre() { Name = "Horor"},
                new Genre() { Name = "Komický román"},
                new Genre() { Name = "Lekársky román"},
                new Genre() { Name = "Politický román"},
                new Genre() { Name = "Romanca"},
                new Genre() { Name = "Satira"},
                new Genre() { Name = "Science fiction"},
                new Genre() { Name = "Sága"},
                new Genre() { Name = "Triler"},
                new Genre() { Name = "Tragédia"},
                new Genre() { Name = "Zločinecký román"},
                new Genre() { Name = "Detektívna literatúra"},
            ];
    }
}
