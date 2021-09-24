
namespace SistemaBibliotecarioManas.Application.Models.Usuario
{
    public abstract class UsuarioModelBase
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}
