using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plat1.Data;
using Plat1.Models;
using System.Linq;

namespace Plat1.Controllers
{
    public class AdminController : Controller
    {
        // GET: ClientController
        private readonly AppDbContext _context;
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            var client = _context.Clients.ToList();
            return View(client);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order client)
        {
            try
            {
                _context.Clients.Add(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            var plat = _context.Clients.Find(id);
            return View(plat);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order client)
        {
            try
            {
                _context.Clients.Update(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _context.Clients.Find(id);
            return View(client);
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Order client)
        {
            try
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

