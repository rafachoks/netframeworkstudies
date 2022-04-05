using Blinks.Project.Domain;
using FluentValidation;

namespace Blinks.Project.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("Informe o nome do usuário este campo não pode ser vazio")
           .NotNull().WithMessage("Informe o nome do usuário este campo não pode ser vazio")
           .WithSeverity(Severity.Error);

            RuleFor(x => x.Email)
           .NotEmpty().WithMessage("Informe um endereço de e-mail para o usuário, este campo não pode ser vazio")
           .NotNull().WithMessage("Informe um endereço de e-mail para o usuário, este campo não pode ser vazio")
           .WithSeverity(Severity.Error);
        }
    }
}
