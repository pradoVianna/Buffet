using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BUFFET.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BUFFET.Models;
using BUFFET.Models.Buffet.Access;
using BUFFET.Models.Buffet.Cliente;
using BUFFET.Models.Buffet.Convidado;
using BUFFET.Models.Buffet.Evento;

namespace BUFFET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UsuarioService _usuarioService;
        private readonly ClienteService _clienteService;
        private readonly EventoService _eventoService;
        private readonly ConvidadoService _convidadoService;
        public HomeController(ILogger<HomeController> logger, UsuarioService usuarioService,
            ClienteService clienteService, EventoService eventoService, ConvidadoService convidadoService)
        {
            _logger = logger;
            _usuarioService = usuarioService;
            _clienteService = clienteService;
            _eventoService =  eventoService;
            _convidadoService = convidadoService;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        
        public IActionResult TermosUso()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}