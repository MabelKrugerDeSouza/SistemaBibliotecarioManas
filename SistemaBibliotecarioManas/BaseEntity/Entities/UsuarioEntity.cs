
namespace SistemaBiblitecarioManas.Entities.Entities
{
     public class UsuarioEntity : BaseEntity
    {
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public void Login()
        {
        }
    }
}
