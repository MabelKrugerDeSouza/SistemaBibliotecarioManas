using Microsoft.EntityFrameworkCore;
using SistemaBibliotecarioManas.Infra.Repository.GenericRepository;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Infra.Repository.LivroRepository
{
    public class LivroRepository : GenericRepository<LivroEntity>, ILivroRepository
    {
        private readonly MainContext _dbContex;

        public LivroRepository(MainContext context) : base(context)
        {
        }

        public async Task<bool> VerificarSeExisteLivroComMesmoId(int id)
        {
            return await _dbSet.AnyAsync(x => x.Id != id && x.Deletado != true);
        }
    }
}
