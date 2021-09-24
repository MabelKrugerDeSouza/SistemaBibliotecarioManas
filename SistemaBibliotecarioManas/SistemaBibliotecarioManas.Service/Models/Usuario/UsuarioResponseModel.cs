using SistemaBiblitecarioManas.Entities.Entities;

namespace SistemaBibliotecarioManas.Application.Models.Usuario
{
    public class UsuarioResponseModel : UsuarioModelBase
    {
        public UsuarioResponseModel(UsuarioEntity usuario)
        {
            Id = usuario.Id;
            NomeUsuario = usuario.NomeUsuario;
            Senha = usuario.Senha;
            Email = usuario.Email;
        }
    }
}
