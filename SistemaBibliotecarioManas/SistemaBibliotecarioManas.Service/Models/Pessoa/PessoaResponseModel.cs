using SistemaBibliotecarioManas.Application.Models.EnderecoModel;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Application.Models.Pessoa
{
    public class PessoaResponseModel : PessoaModelBase
    {
        public int Id { get; set; }
        public PessoaResponseModel(PessoaEntity pessoa)
        {
            Id = pessoa.Id;
            NomePessoa = pessoa.NomePessoa;
            Email = pessoa.Email;
            CPF = pessoa.CPF;
            DataNascimento = pessoa.DataNascimento;
            Telefone = pessoa.Telefone;
            TipoPessoa = pessoa.TipoPessoa;

            Endereco = new EnderecoModelTeste
            {
                Rua = pessoa.Endereco.Rua,
                Cidade = pessoa.Endereco.Cidade,
                CEP = pessoa.Endereco.CEP,
                Bairro = pessoa.Endereco.Bairro,
                Numero = pessoa.Endereco.Numero,
                Complemento = pessoa.Endereco.Complemento,
                UF = pessoa.Endereco.UF
            };
        }
    }
}
