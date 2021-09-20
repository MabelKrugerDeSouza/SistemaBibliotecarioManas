using SistemaBibliotecarioManas.Application.Models.Livro;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System;
using System.Collections.Generic;
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

        public async Task<int> Create(LivroRequestModel request)
        {
            var livro = new LivroEntity(request.NomeLivro, request.Id);
            var livroJaExiste = await _repository.VerificarSeExisteLivroComMesmoId(livro.NomeLivro,livro.Id);

            if (livroJaExiste)
            {
                throw new ArgumentException("Livro com o mesmo Id já existe.");
            }
            livro.Validate();
            await _repository.Create(livro);
            return livro.Id;
        }

        public async Task<LivroEntity> Delete(int id)
        {
            var livro = await _repository.GetById(id);
            if (livro == null)
            {
                throw new ArgumentException("Livro inexistente");
            }
            livro.Delete();
            await _repository.Delete(livro);
            return livro;
        }

        public async Task<List<LivroResponseModel>> GetAll()
        {
            var livroRepositorio = await _repository.GetAll();
            var livroResponse = new List<LivroResponseModel>();

            foreach (var item in livroRepositorio)
            {
                var categorias = new LivroResponseModel(item);
                livroResponse.Add(categorias);
            }
            return livroResponse;
        }

        public async Task<LivroResponseModel> GetById(int id)
        {
            var livro = await _repository.GetById(id);
            if (livro == null)
            {
                throw new ArgumentException("Id do livro não existe.");
            }

            var categoriaResponseModel = new LivroResponseModel(livro);
            return categoriaResponseModel;
        }

        public async Task<LivroEntity> Update(int id, LivroRequestModel request)
        {
            var livro = await _repository.GetById(id);
            if (livro == null)
            {
                throw new ArgumentException("Id da categoria inválido.");
            }

            livro.Update(request.NomeLivro, request.Id);
            livro.Validate();

            var categoriaExiste = await _repository.VerificarSeExisteLivroComMesmoId(livro.NomeLivro, livro.Id);
            if (categoriaExiste)
            {
                throw new ArgumentException("Livro com mesmo id ja existe.");
            }
            await _repository.Update(livro);
            return livro;
        }
    }
}
