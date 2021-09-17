using SistemaBibliotecarioManas.Application.Models.Livro;
using SistemaBiblitecarioManas.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Livro
{
    public interface ILivroService
    {
        Task<int> Create(LivroRequestModel request);
        Task<LivroEntity> Update(int id, LivroRequestModel request);
        Task<LivroEntity> Delete(int id);
        Task<LivroResponseModel> GetById(int id);
        Task<List<LivroResponseModel>> GetAll();
    }
}
