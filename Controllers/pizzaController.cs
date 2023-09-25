using Microsoft.AspNetCore.Mvc;

namespace Plat1.Controllers
{
    public class pizzaController : Controller
    {
        public IActionResult pizza()
        {
            return View();
        }
    }
}
