using SistemaBiblitecarioManas.Entities.Entities;
using System.Threading.Tasks;

namespace SistemaBiblitecarioManas.Entities.Interface
{
    public interface ILivroRepository : IGenericRepository<LivroEntity>
    {
        Task<bool> VerificarSeExisteLivroComMesmoId(string nomeLivro, int id);
    }
}
