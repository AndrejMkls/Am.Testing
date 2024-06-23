using Am.Testing.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Validations
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator() 
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .WithMessage("Titul je povinný.");

            RuleFor(author => author.Title)
               .MaximumLength(100)
               .WithMessage("Maximálna dĺžka titulu je 100 znakov.");

            RuleFor(author => author.ISBN)
               .MaximumLength(100)
               .WithMessage("Maximálna dĺžka ISBN je 15 znakov.");

            RuleFor(author => author.Authors)
               .NotEmpty()
               .WithMessage("Aspoň 1 autor musí byť priradený.");

            RuleFor(author => author.Genres)
               .NotEmpty()
               .WithMessage("Aspoň 1 žáner musí byť priradený.");

            RuleFor(item => item.PublisherId)
                .NotEmpty()
                .WithMessage("Vydavateľstvo musí byť zvolené");

            RuleFor(author => author.PublicationDate)
               .LessThanOrEqualTo(DateTime.Today)
               .WithMessage("Dátum vydania nesmie byť novší ako aktuálny deň.");

            RuleFor(author => author.Edition)
               .MaximumLength(15)
               .WithMessage("Maximálna dĺžka edície je 15 znakov.");

            RuleFor(author => author.Summary)
               .MaximumLength(500)
               .WithMessage("Maximálna dĺžka zhrnutia je 500 znakov.");

            RuleFor(author => author.Language)
              .MaximumLength(20)
              .WithMessage("Maximálna dĺžka jazyka je 20 znakov.");

            RuleFor(item => item.CoverTypeId)
                .NotEmpty()
                .WithMessage("Typ obalu musí byť zvolený.");
        }
    }
}
