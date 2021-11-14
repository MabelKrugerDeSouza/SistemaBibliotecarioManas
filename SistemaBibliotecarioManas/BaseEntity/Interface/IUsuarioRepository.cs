using SistemaBiblitecarioManas.Entities.Entities;
using System.Threading.Tasks;

namespace SistemaBiblitecarioManas.Entities.Interface
{
    public interface IUsuarioRepository : IGenericRepository<UsuarioEntity>
    {
        Task<bool> EmailJaCadastrado(string email);
        Task<bool> SenhaOuEmailInvalido(string senha, string email);
        Task<bool> PessoaJaExisteComEsseEmail(string email, int id);
    }
}
