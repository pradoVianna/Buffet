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

namespace BUFFET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext _dataBaseContext;
        public HomeController(ILogger<HomeController> logger
            ,DataBaseContext dataBaseContext
        )
        {
            _logger = logger;
            _dataBaseContext = dataBaseContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
    
        public IActionResult Cadastro()
        {
            return View();
        }
        
        public IActionResult RecSenha()
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