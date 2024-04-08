using Am.Testing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.App.Seeding
{
    public class CoverTypeSeeding
    {
        private readonly IList<CoverType> _items;

        public IList<CoverType> Items { get => _items; }

        public CoverTypeSeeding() => _items =
            [
                new CoverType() { Name = "Šitá väzba V1"},
                new CoverType() { Name = "Lepená väzba V2"},
                new CoverType() { Name = "Bloková väzba V3"},
                new CoverType() { Name = "Mäkká šitá väzba V4"},
                new CoverType() { Name = "Polotuhá väzba V5"},
                new CoverType() { Name = "Leporel V6"},
                new CoverType() { Name = "Tvrdá väzba V7"},
                new CoverType() { Name = "Tvrdá väzba V8"},
                new CoverType() { Name = "Tvrdá väzba V9"},
                new CoverType() { Name = "Flexoväzba"},
                new CoverType() { Name = "Špirálová väzba"},
                new CoverType() { Name = "Hrebeňová väzba"},
            ];
    }
}
