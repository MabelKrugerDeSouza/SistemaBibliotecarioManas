using SistemaBibliotecarioManas.Application.Models.Usuario;
using SistemaBiblitecarioManas.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Usuario
{
    public interface IUsuarioService
    {
        Task<int> Create(UsuarioRequestModel model);
        Task<bool> Login(string email, string senha);
        Task<UsuarioEntity> Delete(int id);
        Task<UsuarioEntity> Update(int id, UsuarioRequestModel request);
        Task<UsuarioResponseModel> GetById(int id);
        Task<List<UsuarioResponseModel>> GetAll();
    }
}
