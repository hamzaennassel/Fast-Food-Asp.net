using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plat1.Data;
using Plat1.Models;

namespace Plat1.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
       public OrderController(AppDbContext context)
        {
            _context = context;
        }

            // GET: ClientController1/Create
            public ActionResult Order()
            {
                return View(new Order());
            }

            // POST: ClientController1/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Order(Order client)
            {
                try
                {
                _context.Clients.Add(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Order));
                }
                catch
                {
                    return View();
                }
            }

        
        }
    }
