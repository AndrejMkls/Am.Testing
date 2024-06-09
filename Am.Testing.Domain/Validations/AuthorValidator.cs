using Am.Testing.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Validations
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator() 
        {
            RuleFor(author => author.FullName)
                .NotEmpty()
                .WithMessage("Celé meno je povinné.");

            RuleFor(author => author.FullName)
                .MaximumLength(100)
                .WithMessage("Maximálna dĺžka celého mena je 100 znakov.");

            RuleFor(author => author.FirstName)
                .NotEmpty()
                .WithMessage("Krstné meno je povinné.");

            RuleFor(author => author.FirstName)
                .MaximumLength(50)
                .WithMessage("Maximálna dĺžka krstného mena je 50 znakov.");

            RuleFor(author => author.LastName)
                .NotEmpty()
                .WithMessage("Priezvisko je povinné.");

            RuleFor(author => author.LastName)
               .MaximumLength(50)
               .WithMessage("Maximálna dĺžka priezviska je 50 znakov.");

            RuleFor(author => author.Nationality)
                .MaximumLength(50)
                .WithMessage("Maximálna dĺžka národnosti je 50 znakov.");

            RuleFor(author => author.BirthYear)
                .LessThanOrEqualTo(DateTime.Now.Year)
                .WithMessage("Rok narodenia nesmie byť väčší alebo rovnaký ako aktuály rok.");


        }
    }
}
