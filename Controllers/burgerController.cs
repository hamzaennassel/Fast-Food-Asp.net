using Microsoft.AspNetCore.Mvc;

namespace Plat1.Controllers
{
    public class burgerController : Controller
    {
        public IActionResult burger()
        {
            return View();
        }
    }
}
