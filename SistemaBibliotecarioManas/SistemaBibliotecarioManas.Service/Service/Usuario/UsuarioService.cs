using SistemaBibliotecarioManas.Application.Models.Usuario;
using SistemaBiblitecarioManas.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        public Task<int> Create(UsuarioRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioEntity> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioResponseModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioResponseModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioEntity> Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioEntity> Update(string nomeUsuario, string senha, string email)
        {
            throw new NotImplementedException();
        }
    }
}
