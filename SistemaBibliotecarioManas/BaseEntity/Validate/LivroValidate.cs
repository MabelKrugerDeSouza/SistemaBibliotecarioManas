using FluentValidation;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBiblitecarioManas.Entities.Validate
{
    public class LivroValidate : AbstractValidator<LivroEntity>
    {
        public LivroValidate()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(l => l.NomeAutor).NotEmpty().WithMessage("Nome do Autor não informado.")
                .MinimumLength(3).WithMessage("Nome do autor deve ter no minimo 3 caracteres.")
                .MaximumLength(30).WithMessage("Nome do autor deve ter no máximo 30 caracteres.");

            RuleFor(l => l.NomeLivro).NotEmpty().WithMessage("Nome do livro não informado.")
                .MinimumLength(3).WithMessage("Nome do livro deve ter no minino 3 caracteres.")
                .MaximumLength(30).WithMessage("Nome do livro deve ter no minino 30 caracteres.");

            RuleFor(l => l.GeneroDoLivro).NotNull().WithMessage("Genero do livro não informado.");

            RuleFor(l => l.Editora).NotEmpty().WithMessage("Nome da editora não informado.")
                .MinimumLength(3).WithMessage("Nome da editora deve ter no minimo 3 caracteres.")
                .MaximumLength(30).WithMessage("Nome da editora deve ter no máximo 30 caracteres.");

            RuleFor(l => l.Paginas).NotNull().WithMessage("Numero de páginas nao inforado.");

            RuleFor(l => l.Idioma).NotEmpty().WithMessage("Idioma não informado")
                .MinimumLength(3).WithMessage("Idioma deve ter no minino 3 caracteres.")
                .MaximumLength(20).WithMessage("Idioma dever ter no máximo 20 caracteres.");

            RuleFor(l => l.DataPublicacao).NotNull().WithMessage("Data de publicação nao informada.");
        }
    }
}
