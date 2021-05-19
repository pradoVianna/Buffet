using BUFFET.Models.Buffet.Cliente;
using BUFFET.ViewModels.Interno;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    [Authorize]
    public class InternoController : Controller
    {
        private readonly ClienteService _clienteService;
        // GET
        public InternoController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

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
        
        //listar::cliente
        public IActionResult Cliente()
        {
            var viewModel = new ClienteViewModel();

            var listaClientes = _clienteService.ObterTodos();

            foreach (ClienteEntity clienteEntity in listaClientes)
            {
                
            }
            
            return View(viewModel);
        }
        //add::cliente
        public IActionResult CadCliente()
        {
            return View();
        }
        public IActionResult CadEvento()
        {
            return View();
        }
        public IActionResult Locais()
        {
            return View();
        }
        public IActionResult CadLocal()
        {
            return View();
        }
        
        
        
    }
}