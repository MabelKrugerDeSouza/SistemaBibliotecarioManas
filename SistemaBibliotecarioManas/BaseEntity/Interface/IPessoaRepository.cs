using SistemaBiblitecarioManas.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblitecarioManas.Entities.Interface
{
    public interface IPessoaRepository : IGenericRepository<PessoaEntity>
    {
        Task<bool> PessoaJaExiste(string cpf);
        Task<bool> PessoaJaExisteComEsseCpf(string cpf, int id);
    }
}
