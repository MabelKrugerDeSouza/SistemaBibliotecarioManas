using SistemaBiblitecarioManas.Entities.Enum;
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
    }
}
