using SistemaBiblitecarioManas.Entities.Entities;
using System.Threading.Tasks;

namespace SistemaBiblitecarioManas.Entities.Interface
{
    public interface IUsuarioRepository : IGenericRepository<UsuarioEntity>
    {
        Task<bool> EmailJaCadastrado(string email);
        Task<bool> Login(string email, string senha);
        Task<bool> PessoaJaExisteComEsseEmail(string email, int id);
    }
}
