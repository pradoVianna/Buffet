using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    public class AcessoController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}