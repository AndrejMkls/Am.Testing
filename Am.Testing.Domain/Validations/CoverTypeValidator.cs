using Am.Testing.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Validations
{
    public class CoverTypeValidator : AbstractValidator<CoverType>
    {
        public CoverTypeValidator() 
        {
            RuleFor( x => x.Name )
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
