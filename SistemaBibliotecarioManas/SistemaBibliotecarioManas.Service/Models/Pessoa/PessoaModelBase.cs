using SistemaBiblitecarioManas.Entities;
using SistemaBiblitecarioManas.Entities.Complex_Type;
using System;

namespace SistemaBibliotecarioManas.Application.Models.Pessoa
{
    public class PessoaModelBase
    {
        public string NomePessoa { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
    }
}
