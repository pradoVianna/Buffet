using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    [Authorize]
    public class InternoController : Controller
    {
        // GET
        public IActionResult Index()
        {
            
            
            return View();
        }
        public IActionResult TermosUso()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Ajuda()
        {
            return View();
        }
        public IActionResult Agenda()
        {
            return View();
        }
        public IActionResult Eventos()
        {
            return View();
        }
        public IActionResult Financeiro()
        {
            return View();
        }
        public IActionResult MinhaConta()
        {
            return View();
        }
        public IActionResult Cliente()
        {
            return View();
        }
        
        public IActionResult CadCliente()
        {
            return View();
        }
    }
}