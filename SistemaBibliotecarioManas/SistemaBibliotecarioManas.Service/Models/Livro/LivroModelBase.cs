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
    }
}
