﻿using SistemaBibliotecarioManas.Application.Models.Usuario;
using SistemaBiblitecarioManas.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Usuario
{
    public interface IUsuarioService
    {
        Task<int> Create(UsuarioRequestModel model);
        Task<UsuarioEntity> Login(string email, string senha);
        Task<UsuarioEntity> Delete(int id);
        Task<UsuarioEntity> Update(string nomeUsuario, string senha, string email, int id);
        Task<UsuarioResponseModel> GetById(int id);
        Task<List<UsuarioResponseModel>> GetAll();
    }
}
