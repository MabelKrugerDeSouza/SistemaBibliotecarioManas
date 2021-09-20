using FluentValidation;
using SistemaBiblitecarioManas.Entities.Enum;
using SistemaBiblitecarioManas.Entities.Validate;
using System;

namespace SistemaBiblitecarioManas.Entities.Entities
{
    public class LivroEntity : BaseEntity
    {
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
        public GeneroDoLivro GeneroDoLivro { get; set; }
        public string Editora { get; set; }
        public int Paginas { get; set; }
        public string Idioma { get; set; }
        public DateTime DataPublicacao { get; set; }

        public LivroEntity(string nomeLivro, int id)
        {
            NomeLivro = nomeLivro;
            Id = id;
            Validate();
        }

        private LivroEntity() {  }

        public void Update(string nomeLivro, int id)
        {
            NomeLivro = nomeLivro;
            Id = id;
            Validate();
        }

        public void Delete()
        {
            Deletado = true;
        }

        public void Validate()
        {
            var livroValidator = new LivroValidate();
            livroValidator.ValidateAndThrow(this);
        }
    }
}
