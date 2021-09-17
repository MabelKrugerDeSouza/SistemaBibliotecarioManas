using SistemaBiblitecarioManas.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Service
{
    public interface IPessoaService
    {
        Task<int> Create(PessoaRequestModel request);
        Task<PessoaEntity> Update(int id, PessoaRequestModel request);
        Task<PessoaEntity> Delete(int id);
        Task<PessoaResponseModel> GetById(int id);
        Task<List<PessoaResponseModel>> GetAll();
    }
}
