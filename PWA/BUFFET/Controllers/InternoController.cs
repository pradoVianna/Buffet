using System.Reflection.Metadata;
using BUFFET.Models.Buffet.Evento;
using BUFFET.ViewModels.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    [Authorize]
    public class InternoController : Controller
    {
        private readonly EventoLocalService _eventoLocalService;

        public InternoController(EventoLocalService eventoLocalService)
        {
            _eventoLocalService = eventoLocalService;
        }

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
        public IActionResult CadEvento()
        {
            return View();
        }
        
        public IActionResult CadLocal()
        {
            return View();
        }
        public IActionResult Locais()
        {
            var viewModel = new LocaisViewModel();

            var listaLocais = _eventoLocalService.ListaTodos();

            foreach (EventoLocal eventoLocal in listaLocais)
            {
                viewModel.Local.Add(new Local()
                {
                    Id = eventoLocal.Descricao.ToString(),
                    Descricao = eventoLocal.Descricao.ToString(),
                    Endereco = eventoLocal.Endereco.ToString()
                });

            }
            return View(viewModel);
        }
        
        public IActionResult Adicionar()
        {
            return View();
        }
        
        public IActionResult Editar()
        {
            return View();
        }
        
        public IActionResult Deletar()
        {
            return View();
        }
        
        
    }
}