using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plat1.Data;
using Plat1.Models;
using System.Linq;

namespace Plat1.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        public CartController(AppDbContext context)
        {
            _context = context;
        }
        // GET: CartController
        public ActionResult Index()
        {
            var plat = _context.plats.ToList();
            return View(plat);
        }

     

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plat plat)
        {
            try
            {
                _context.plats.Add(plat);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            var plat = _context.plats.Find(id);
            return View(plat);
        }

        // POST: CartController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Plat plat)
        {
            try
            {
                _context.plats.Update(plat);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
              
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            var plat = _context.plats.Find(id);
            return View(plat);
        }

        // POST: CartController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Plat plat)
        {
            try
            {
                _context.plats.Remove(plat);
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
