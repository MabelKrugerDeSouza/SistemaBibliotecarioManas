using System.Threading.Tasks;

namespace SistemaBiblitecarioManas.Entities.Interface
{
    public interface IUsuarioRepository
    {
        Task<bool> EmailJaCadastrado(string email);
        Task<bool> SenhaOuEmailInvalido(string senha, string email);
    }
}
