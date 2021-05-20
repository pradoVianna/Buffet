using System;
using System.Security.Claims;
using System.Threading.Tasks;
using BUFFET.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Models.Buffet.Access
{
    public class UsuarioService
    {

        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _singInManager;
        

        //private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly DataBaseContext _dataBaseContext;
        

        public UsuarioService(UserManager<Usuario> userManager, SignInManager<Usuario> singInManager)
        {
           // _dataBaseContext = dataBaseContext;
           _userManager = userManager;
           _singInManager = singInManager;
           //_httpContextAccessor = httpContextAccessor;
        }

        
        //public async Task<Usuario> GetUser()
        //{
        //    var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        //   return user;

        public async Task Editar(string name, IDadosBasicosUser dadosBasicosUser)
        {
            var user = await _userManager.FindByNameAsync(name);
            var userEdit = Validador(user, dadosBasicosUser);
            var resultado = await _userManager.UpdateAsync(await userEdit);
            if (resultado.Succeeded)
            {
                throw new Exception("Usuario atualizado com sucesso!");
            }

        }

        public async Task<Usuario> Validador(Usuario uExists,IDadosBasicosUser dados)
        {
            var u = uExists;
            if (dados.Username == null)
            {
                throw new Exception("Username inválido");
                
            }

            u.UserName = dados.Username;
            if (dados.Senha != dados.ConfirmSenha)
            {
                throw new Exception("Senhas diferentes");
            }
            else
            {
                var result =await  _userManager.ChangePasswordAsync(u, dados.AtualSenha, dados.ConfirmSenha);
            }

            return u;
        }
        public async Task AuthUser(string userName, string senha)
        {
            var resultado = await _singInManager.PasswordSignInAsync(userName, senha, false, false);
            if (!resultado.Succeeded)
            {
                throw new Exception("E-mail ou senha inválidos.");
            }
        }
        public async Task RegisterUser(string nome, string email, string senha, string confirmSenha)
        {
            var novoUser = new Usuario()
            {
                UserName = nome,
                Email = email
            };
            
               var resultado = await _userManager.CreateAsync(novoUser, senha);

               if (!resultado.Succeeded)
               {
                   throw new CadastroUsuarioException(resultado.Errors);
               }
            
        }
        
    }

    public interface IDadosBasicosUser
    {
        public string Username { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
        public string AtualSenha { get; set; }
    }
}