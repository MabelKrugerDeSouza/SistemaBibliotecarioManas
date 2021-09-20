using Microsoft.EntityFrameworkCore;
using SistemaBibliotecarioManas.Infra.Repository.GenericRepository;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Infra.Repository.PessoaRepository
{
    public class PessoaRepository : GenericRepository<PessoaEntity>, IPessoaRepository
    {
        public readonly MainContext _dbContext;

        public PessoaRepository(MainContext context) : base(context) { }

        public async Task<bool> PessoaJaExiste(string cpf)
        {
            return await _dbSet.AnyAsync(p => p.CPF == cpf && p.Deletado != true);
        }
        
        public async Task<bool> PessoaJaExisteComEsseCpf(string cpf, int id)
        {
            return await _dbSet.AnyAsync(p => p.CPF == cpf && p.Id == id && p.Deletado != true);
        }
    }
}
