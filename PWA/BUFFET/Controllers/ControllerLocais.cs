using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    public class ControllerLocais : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}