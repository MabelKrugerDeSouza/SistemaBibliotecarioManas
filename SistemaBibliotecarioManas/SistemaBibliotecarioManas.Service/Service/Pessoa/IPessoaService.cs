using SistemaBibliotecarioManas.Application.Models.Pessoa;
using SistemaBiblitecarioManas.Entities.Complex_Type;
using SistemaBiblitecarioManas.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Service
{
    public interface IPessoaService
    {
        Task<int> Create(PessoaRequestModel request);
        Task<PessoaEntity> Update(string nomePessoa, string email, string cpf, DateTime dataNascimento, string telefone, Endereco endereco, int id);
        Task<PessoaEntity> Delete(int id);
        Task<PessoaResponseModel> GetById(int id);
        Task<List<PessoaResponseModel>> GetAll();
    }
}
