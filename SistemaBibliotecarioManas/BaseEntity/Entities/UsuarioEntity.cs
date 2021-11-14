using FluentValidation;
using SistemaBiblitecarioManas.Entities.Validate;

namespace SistemaBiblitecarioManas.Entities.Entities
{
     public class UsuarioEntity : BaseEntity
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public UsuarioEntity() { }

        public void Update(string nomeUsuario, string senha, string email)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Email = email;

        }

        public void Delete()
        {
            Deletado = true;
        }

        public void Validate()
        {
            var usuarioValidate = new UsuarioValidate();
            usuarioValidate.ValidateAndThrow(this);
        }
    }
}
