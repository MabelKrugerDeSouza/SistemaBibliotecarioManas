﻿using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Application.Models.Livro
{
    public class LivroResponseModel : LivroModelBase
    {
        public LivroResponseModel(LivroEntity livro)
        {
            Id = livro.Id;
            NomeAutor = livro.NomeAutor;
            NomeLivro = livro.NomeLivro;
            GeneroDoLivro = livro.GeneroDoLivro;

        }
    }
}
