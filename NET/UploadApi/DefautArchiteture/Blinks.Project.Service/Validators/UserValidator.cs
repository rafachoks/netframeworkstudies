using Blinks.Project.Domain;
using FluentValidation;

namespace Blinks.Project.Service.Validators
{
    [Obsolete("Não precisamos mais usar Service para comunicar com o banco, toda validação de campos deve ser feita na camada de Application")]
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

            RuleFor(x => x.Age)
            .NotEmpty()
            .WithName("Erro Idade")
            .WithMessage("A partir do dia 15 de Maio este projeto não ira usar este objeto")
            .WithSeverity(Severity.Info);
        }
    }
}
