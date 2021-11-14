using SistemaBibliotecarioManas.Application.Models.Usuario;
using SistemaBiblitecarioManas.Entities.Entities;
using SistemaBiblitecarioManas.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBibliotecarioManas.Application.Service.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Create(UsuarioRequestModel model)
        {
            var usuario = new UsuarioEntity();
            var emailJaCadastrado = await _repository.EmailJaCadastrado(usuario.Email);

            if (emailJaCadastrado)
            {
                throw new ArgumentException("E-mail já cadastrado");
            }
            usuario.Validate();
            await _repository.Create(usuario);
            return usuario.Id;
        }

        public async Task<UsuarioEntity> Delete(int id)
        {
            var usuario = await _repository.GetById(id);
            if(usuario == null)
            {
                throw new ArgumentException("Usuario inexistente");
            }

            usuario.Delete();
            await _repository.Delete(usuario);
            return usuario;
        }

        public async Task<List<UsuarioResponseModel>> GetAll()
        {
            var pegarTodosOsUsuarios = await _repository.GetAll();
            var usuarioResponse = new List<UsuarioResponseModel>();

            foreach (var usuarioLista in pegarTodosOsUsuarios)
            {
                var usuarios = new UsuarioResponseModel(usuarioLista);
                usuarioResponse.Add(usuarios);
            }
            return usuarioResponse;
        }

        public async Task<UsuarioResponseModel> GetById(int id)
        {
            var idUsuario = await _repository.GetById(id);
            if(idUsuario == null)
            {
                throw new ArgumentException("Id de usuário inexistente");
            }

            var usuarioResponseModel = new UsuarioResponseModel(idUsuario);
            return usuarioResponseModel;
        }

        public Task<UsuarioEntity> Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioEntity> Update(int id, UsuarioRequestModel request)
        {
            var encontrarUsuario = await _repository.GetById(id);
            if(encontrarUsuario == null)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            encontrarUsuario.Update(request.NomeUsuario, request.Senha, request.Email);
            encontrarUsuario.Validate();

            var verificandoUsuario = await _repository.PessoaJaExisteComEsseEmail(encontrarUsuario.Email, encontrarUsuario.Id);
            if (verificandoUsuario)
            {
                throw new ArgumentException("E-mail já existe");
            }
            await _repository.Update(encontrarUsuario);
            return encontrarUsuario;
        }
    }
}
