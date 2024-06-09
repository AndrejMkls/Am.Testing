using Am.Testing.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.Domain.Validations
{
    public class PublisherValidator : AbstractValidator<Publisher>
    {
        public PublisherValidator()
        {
            RuleFor(x => x.Name).NotEmpty()
                                .WithMessage("Meno je povinné");

            RuleFor(x => x.Name).MaximumLength(50)
                                .WithMessage("Maximálna dĺžka mena je 100 znakov");

            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.PhoneNumber).Matches("/(\\+\\d{1,3}\\s?)?((\\(\\d{3}\\)\\s?)|(\\d{3})(\\s|-?))(\\d{3}(\\s|-?))(\\d{4})(\\s?(([E|e]xt[:|.|]?)|x|X)(\\s?\\d+))?/g");

            RuleFor(author => author.YearFounded)
             .LessThanOrEqualTo(DateTime.Now.Year)
             .WithMessage("Rok založenia nesmie byť väčší alebo rovnaký ako aktuály rok.");



        }
    }
}
