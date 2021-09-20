using SistemaBibliotecarioManas.Application.Models.Pessoa;
using SistemaBibliotecarioManas.Service;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Pessoa
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repositorio;

        public PessoaService(IPessoaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<int> Create(PessoaRequestModel request)
        {
            var pessoa = new PessoaEntity();
            var livroJaExiste = await _repositorio.PessoaJaExiste(pessoa.CPF);

            if (livroJaExiste)
            {
                throw new ArgumentException("CPF informado já existe.");
            }
            pessoa.Validate();
            await _repositorio.Create(pessoa);
            return pessoa.Id;
        }

        public async Task<PessoaEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PessoaResponseModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PessoaResponseModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PessoaEntity> Update(int id, PessoaRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
