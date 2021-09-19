using FluentValidation;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Enum;
using System.Data;

namespace SistemaBiblitecarioManas.Entities.Validate
{
    public class LivroValidate : AbstractValidator<LivroEntity>
    {
        public LivroValidate()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(l => l.NomeAutor).NotEmpty().WithMessage("Nome do Autor inválido.")
                .MinimumLength(3).WithMessage("Nome do autor deve ter no minimo 3 caracteres.")
                .MaximumLength(30).WithMessage("Nome do autor deve ter no máximo 30 caracteres.");

            RuleFor(l => l.NomeLivro).NotEmpty().WithMessage("Nome do livro inválido.")
                .MinimumLength(3).WithMessage("Nome do livro deve ter no minino 3 caracteres.")
                .MaximumLength(30).WithMessage("Nome do livro deve ter no minino 30 caracteres.");

            RuleFor(x => x.GeneroDoLivro).NotNull().WithMessage("Genero do livro não informado.");
        }
    }
}
