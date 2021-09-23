using FluentValidation;
using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBiblitecarioManas.Entities.Validate
{
    public class PessoaValidate: AbstractValidator<PessoaEntity>
    {
        public PessoaValidate()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(p => p.NomePessoa).NotEmpty().WithMessage("Nome pessoa não informado.")
                .MinimumLength(3).WithMessage("Pessoa deve ter no minino 3 caracteres.")
                .MaximumLength(50).WithMessage("Pessoa deve ter no máximo 50 caracteres.");

            RuleFor(p => p.Email).NotEmpty().WithMessage("E-mail não informado.")
               .EmailAddress().WithMessage("Email informado está incorreto. EX:exemplo@gmail.com.")
               .MaximumLength(60).WithMessage("Email não pode conter mais de 60 caracteres.");

            RuleFor(p => p.CPF).NotNull().WithMessage("CPF não informado")
                .NotNull().WithMessage("CPF não pode ser nulo.")
                .Must(ValidacaoCPF).WithMessage("CPF incorreto.");

            RuleFor(p => p.DataNascimento).NotNull().WithMessage("Data de nascimento não informado");

            RuleFor(p => p.Telefone).NotNull().WithMessage("Telefone não informado.")
                .MinimumLength(10).WithMessage("Telefone deve conter exatamente 10 caracteres.")
                .MaximumLength(11).WithMessage("Telefone deve conter exatamente 11 caracteres.");


            RuleFor(p => p.Endereco.Rua).NotEmpty().WithMessage("Rua não informado.")
                .MinimumLength(10).WithMessage("Rua não pode ter menos de 10 caracteres.")
                .MaximumLength(80).WithMessage("Rua não pode ter mais de 80 caracteres.");

            RuleFor(p => p.Endereco.Bairro).NotEmpty().WithMessage("Bairro não informado.")
                .MinimumLength(7).WithMessage("Bairro não pode ter menos de 7 caracteres.")
                .MaximumLength(50).WithMessage("Bairro não pode ter mais de 50 caracteres.");

            RuleFor(p => p.Endereco.CEP).NotEmpty().WithMessage("Cep não informado.")
                .MinimumLength(8).WithMessage("Cep não teve ter menos 8 caracteres.")
                .MaximumLength(8).WithMessage("Cep deve conter exatamente 8 caracteres.");

            RuleFor(p => p.Endereco.Cidade).NotNull().WithMessage("Cidade não informado.")
                .NotEmpty().WithMessage("Cidade não pode ser vazia.")
                .MinimumLength(4).WithMessage("Cidade não pode ter menos de 4 caracteres.")
                .MaximumLength(40).WithMessage("Cidade não pode ter mais de 40 caracteres.");

            RuleFor(p => p.Endereco.Complemento).MaximumLength(70).WithMessage("Complemento não pode ter mais de 70 caracteres.");

            RuleFor(p => p.Endereco.Numero).NotNull().WithMessage("Número não informado.")
                .MaximumLength(6).WithMessage("Numero não pode ter mais de 6 caracteres.");

            RuleFor(p => p.Endereco.UF).NotEmpty().WithMessage("UF não informado.")
                .MinimumLength(2).WithMessage("UF deve conter exatamente 2 caracteres.")
                .MaximumLength(2).WithMessage("UF deve conter exatamente 2 caracteres.");


        }
            private bool ValidacaoCPF(string cpf)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
    }
}
