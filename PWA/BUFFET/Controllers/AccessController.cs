using Microsoft.AspNetCore.Mvc;

namespace BUFFET.Controllers
{
    public class AccessController : Controller
    {
        // GET
        public InternoController Login()
        {
            return Index();
        }
    }
}