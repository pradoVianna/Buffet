using BUFFET.RequestModels;
using BUFFET.ViewModels.System;
using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    public class SystemController : Controller
    {
        // GET
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastro()
        {
            var viewmodel = new CadastroViewModel();
            viewmodel.Message = (string) TempData["msg-cadastro"];
            return View(viewmodel);
        }
        [HttpPost]
        public RedirectResult Cadastro(CadastroAcessoRequestModel request)
        {
            var url = "/System/Cadastro";
            var email = request.Email;
            var nome = request.Nome;
            var senha = request.Senha;
            var confirm = request.SenhaConfirm;

            if (email == null)
            {
                TempData["msg-cadastro"] = "Informe o e-mail";
                return Redirect(url);
            }else if (senha == null)
            {
                TempData["msg-cadastro"] = "Informe a senha";
                return Redirect(url);
            }else if (confirm == null)
            {
                TempData["msg-cadastro"] = "Confirme a senha";
                return Redirect(url);
            }else if (nome == null)
            {
                TempData["msg-cadastro"] = "Informe o nome";
                return Redirect(url);
            }


            return Redirect(url);
        }
        
        public IActionResult RecSenha()
        {
            return View();
        }
    }
}