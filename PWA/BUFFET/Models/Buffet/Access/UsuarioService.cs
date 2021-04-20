using System;
using System.Threading.Tasks;
using BUFFET.Data;
using Microsoft.AspNetCore.Identity;

namespace BUFFET.Models.Buffet.Access
{
    public class UsuarioService
    {

        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _singInManager;
        //private readonly DataBaseContext _dataBaseContext;
        

        public UsuarioService(UserManager<Usuario> userManager, SignInManager<Usuario> singInManager)
        {
           // _dataBaseContext = dataBaseContext;
           _userManager = userManager;
           _singInManager = singInManager;

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
}