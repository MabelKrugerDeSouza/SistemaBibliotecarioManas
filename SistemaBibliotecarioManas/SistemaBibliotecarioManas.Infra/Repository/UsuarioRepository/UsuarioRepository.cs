using Microsoft.EntityFrameworkCore;
using SistemaBibliotecarioManas.Infra.Repository.GenericRepository;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Infra.Repository.UsuarioRepository
{
    public class UsuarioRepository : GenericRepository<UsuarioEntity>, IUsuarioRepository
    {
        public readonly MainContext _dbContext;

        public UsuarioRepository(MainContext context) : base(context){ }

        public async Task<bool> EmailJaCadastrado(string email)
        {
            return await _dbSet.AnyAsync(u => u.Email == email && u.Deletado != true);
        }

        public async Task<bool> PessoaJaExisteComEsseEmail(string email, int id)
        {
            return await _dbSet.AnyAsync(u => u.Email == email && u.Id != id);
        }

        public async Task<bool> Login(string email, string senha)
        {
            var usuario = await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
            if (usuario == null)
            {
                return false;
            }

            if (usuario.Senha != senha)
            {
                return false;
            }

            return true;
        }
    }

}
