using FluentValidation;
using SistemaBiblitecarioManas.Entities.Complex_Type;
using SistemaBiblitecarioManas.Entities.Validate;
using System;

namespace SistemaBiblitecarioManas.Entities.Entities
{
    public class PessoaEntity : BaseEntity
    {
        public string NomePessoa { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public void Update(string nomePessoa, string email, string cpf, DateTime dataNascimento, string telefone, Endereco endereco)
        {
            NomePessoa = nomePessoa;
            Email = email;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void Delete()
        {
            Deletado = true;
        }

        public void Validate()
        {
            var pessoaValidator = new PessoaValidate();
            pessoaValidator.ValidateAndThrow(this);
        }
    }

    
}
