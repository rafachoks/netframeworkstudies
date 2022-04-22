using Blinks.Project.Domain;
using FluentValidation;

namespace Blinks.Project.Service.Validators
{
    public class MidiaValidator : AbstractValidator<Midia>
    {
        [Obsolete("Não precisamos mais usar Service para comunicar com o banco, toda validação de campos deve ser feita na camada de Application")]
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
