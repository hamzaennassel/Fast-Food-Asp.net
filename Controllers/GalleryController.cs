using Microsoft.AspNetCore.Mvc;

namespace Plat1.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }
    }
}
