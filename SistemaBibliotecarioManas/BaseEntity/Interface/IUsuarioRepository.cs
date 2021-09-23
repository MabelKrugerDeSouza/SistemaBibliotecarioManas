using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblitecarioManas.Entities.Interface
{
    public interface IUsuarioRepository
    {
        Task<bool> EmailJaCadastrado(string email);
        Task<bool> SenhaInvalida(string senha);
        Task<bool> SenhaOuEmailInvalido(string senha, string email);
    }
}
