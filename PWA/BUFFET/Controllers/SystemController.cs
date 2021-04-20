using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BUFFET.Models.Buffet.Access;
using BUFFET.RequestModels;
using BUFFET.ViewModels.System;
using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    public class SystemController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public SystemController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET
        public IActionResult Login()
        {  
            var viewmodel = new CadastroViewModel();
            viewmodel.Message = (string) TempData["msg-cadastro"];
            return View(viewmodel);
        }
        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewmodel = new CadastroViewModel();
            viewmodel.Message = (string) TempData["msg-cadastro"];
            viewmodel.ErrosCad = (string[]) TempData["erros-cadastro"];
            
            return View(viewmodel);
        }
        [HttpPost]
        public async Task<RedirectToActionResult> Cadastro(CadastroAcessoRequestModel request)
        {
            //var url = "/System/Cadastro";
            var email = request.Email;
            var nome = request.Name;
            var senha = request.Password;
            var confirm = request.PasswordConfirm;

            if (email == null)
            {
                TempData["msg-cadastro"] = "Informe o e-mail";
                return RedirectToAction("Cadastro");
            }else if (senha == null)
            {
                TempData["msg-cadastro"] = "Informe a senha";
                return RedirectToAction("Cadastro");
            }else if (confirm == null)
            {
                TempData["msg-cadastro"] = "Confirme a senha";
                return RedirectToAction("Cadastro");
            }else if (nome == null)
            {
                TempData["msg-cadastro"] = "Informe o nome";
                return RedirectToAction("Cadastro");
            }

            try
            {
                await _usuarioService.RegisterUser(nome, email, senha, confirm);
                TempData["msg-cadastro"] = "Cadastro realizado com sucesso";
                return RedirectToAction("Login");
            }
            catch (CadastroUsuarioException ex)
            {
                var listaErros = new List<string>();
                foreach (var identityErros in ex.Erros)
                {
                    listaErros.Add(identityErros.Description);
                }
                TempData["erros-cadastro"] = listaErros;
                return RedirectToAction("Cadastro");
            }

            
        }
        
        public IActionResult RecSenha()
        {
            return View();
        }
    }
}