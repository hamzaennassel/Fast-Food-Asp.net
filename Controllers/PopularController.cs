using Microsoft.AspNetCore.Mvc;

namespace Plat1.Controllers
{
    public class PopularController : Controller
    {
        public IActionResult Popular()
        {
            return View();
        }
    }
}
