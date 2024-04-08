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
            
            RuleFor(author => author.FirstName)
                .NotEmpty()
                .WithMessage("Krstné meno je povinné.");

            RuleFor(author => author.LastName)
                .NotEmpty()
                .WithMessage("Priezvisko je povinné.");

            

        }
    }
}
