using FluentValidation;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBiblitecarioManas.Entities.Validate
{
    public class UsuarioValidate : AbstractValidator<UsuarioEntity>
    {
        public UsuarioValidate()
        {
            RuleFor(u => u.NomeUsuario).NotEmpty().WithMessage("Nome do usuário não informado.")
                .MinimumLength(3).WithMessage("Usuário deve ter no minino 3 caracteres.")
                .MaximumLength(50).WithMessage("Usuário deve ter no máximo 50 caracteres.");

            RuleFor(u => u.Email).NotEmpty().WithMessage("E-mail não informado.")
               .EmailAddress().WithMessage("Email informado está incorreto. EX:exemplo@gmail.com.")
               .MaximumLength(60).WithMessage("Email não pode conter mais de 60 caracteres.");

            RuleFor(u => u.Senha).NotNull().WithMessage("Senha nao informada");
        }
    }
}
