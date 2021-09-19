using SistemaBiblitecarioManas.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBibliotecarioManas.Application.Models.Livro
{
    public abstract class LivroModelBase
    {
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string NomeAutor { get; set; }
        public GeneroDoLivro GeneroDoLivro { get; set; }
        public string Editora { get; set; }
        public int Paginas { get; set; }
        public string Idioma { get; set; }
        public DateTime DataPublicacao { get; set; }
    }
}
