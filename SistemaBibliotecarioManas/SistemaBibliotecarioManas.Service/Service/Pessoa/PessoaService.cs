using SistemaBibliotecarioManas.Application.Models.Pessoa;
using SistemaBibliotecarioManas.Service;
using SistemaBiblitecarioManas.Entities.Complex_Type;
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
            var pessoa = await _repositorio.GetById(id);
            if (pessoa == null)
            {
                throw new ArgumentException("Livro inexistente");
            }
            pessoa.Delete();
            await _repositorio.Delete(pessoa);
            return pessoa;
        }

        public async Task<List<PessoaResponseModel>> GetAll()
        {
            var pessoaRepositorio = await _repositorio.GetAll();
            var pessoaResponse = new List<PessoaResponseModel>();

            foreach (var item in pessoaRepositorio)
            {
                var pessoas = new PessoaResponseModel(item);
                pessoaResponse.Add(pessoas);
            }
            return pessoaResponse;
        }

        public async Task<PessoaResponseModel> GetById(int id)
        {
            var pessoa = await _repositorio.GetById(id);
            if (pessoa == null )
            {
                throw new ArgumentException("Id inexistente.");
            }

            var pessoaResponseModel = new PessoaResponseModel(pessoa);
            return pessoaResponseModel;
        }

        public async Task<PessoaEntity> Update(string nomePessoa, string email, string cpf, DateTime dataNascimento, string telefone, Endereco endereco, int id)
        {
            var pessoa = await _repositorio.GetById(id);
            if (pessoa == null)
            {
                throw new ArgumentException("Id invalido.");
            }
       
            pessoa.Update(nomePessoa,email,cpf,dataNascimento,telefone, endereco);
            pessoa.Validate();

            var verificandoCnpj = await _repositorio.PessoaJaExisteComEsseCpf(pessoa.CPF, pessoa.Id);
            if (verificandoCnpj)
            {
                throw new ArgumentException("Fornecedor não poderá ser cadastrado.");
            }
            await _repositorio.Update(pessoa);
            return pessoa;
        }
    }
}
