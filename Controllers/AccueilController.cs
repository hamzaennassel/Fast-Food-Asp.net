using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Plat1.Controllers
{
    public class AccueilController : Controller
    {
        // GET: AccueilController
        public ActionResult Home()
        {
            return View();
        }

       
    }
}
