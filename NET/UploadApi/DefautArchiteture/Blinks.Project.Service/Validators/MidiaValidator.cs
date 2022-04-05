using Blinks.Project.Domain;
using FluentValidation;

namespace Blinks.Project.Service.Validators
{
    internal class MidiaValidator : AbstractValidator<Midia>
    {
        public MidiaValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Informe o nome da Midia")
                .NotNull().WithMessage("Informe o nome da Midia")
                .WithSeverity(Severity.Warning);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Informe uma descrição")
                .NotNull().WithMessage("Informe uma descrição")
                .WithSeverity(Severity.Warning);
        }
    }
}
