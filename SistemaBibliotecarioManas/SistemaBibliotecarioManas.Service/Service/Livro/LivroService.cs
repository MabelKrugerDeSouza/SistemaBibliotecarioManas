using SistemaBibliotecarioManas.Application.Models.Livro;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Livro
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;
        public LivroService(ILivroRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Create(LivroRequestModel livroRequestModel)
        {
            var livro = new LivroEntity(livroRequestModel.NomeLivro, livroRequestModel.Id);

        }
    }
}
