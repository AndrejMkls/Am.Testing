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
                .MaximumLength(100)
                .WithMessage("Celé meno je povinné.");

            RuleFor(author => author.FirstName)
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("Krstné meno je povinné.");

            RuleFor(author => author.LastName)
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("Priezvisko je povinné.");

            RuleFor(author => author.Nationality)
                .MaximumLength(50);

            RuleFor(author => author.BirthYear)
                .LessThanOrEqualTo(DateTime.Now.Year);



        }
    }
}
