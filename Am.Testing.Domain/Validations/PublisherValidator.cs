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

            RuleFor(x => x.Email).MaximumLength(100)
                                .WithMessage("Maximálna dĺžka emailu je 100 znakov");

            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.PhoneNumber).Matches("^\\+421[0-9]{9}$");

            RuleFor(x => x.PhoneNumber).MaximumLength(30)
                               .WithMessage("Maximálna dĺžka tel. čísla je 30 znakov");

            RuleFor(x => x.Website).Must(url => (url is null || url == string.Empty || Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute)))
                                   .WithMessage("Formát web. stránky musí byť korektný.");

            RuleFor(x => x.Website).MaximumLength(50)
                             .WithMessage("Maximálna dĺžka web. stránky je 50 znakov");

            RuleFor(x => x.PublisherType).MaximumLength(50)
                            .WithMessage("Maximálna dĺžka typu vydavateľstva je 50 znakov");

            //RuleFor(x => x.PhoneNumber).Matches("/(\\+\\d{1,3}\\s?)?((\\(\\d{3}\\)\\s?)|(\\d{3})(\\s|-?))(\\d{3}(\\s|-?))(\\d{4})(\\s?(([E|e]xt[:|.|]?)|x|X)(\\s?\\d+))?/g");

            

            RuleFor(author => author.YearFounded)
            .NotEqual(0)
            .WithMessage("Rok založenia nesmie byť rovný 0.");

            RuleFor(author => author.YearFounded)
             .LessThanOrEqualTo(DateTime.Now.Year)
             .WithMessage("Rok založenia nesmie byť väčší alebo rovnaký ako aktuálny rok.");



        }
    }
}
