using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AdminController : Controller
    {
        // ====== TODO: As an admin user, I would like to have a dashboard where I can see a list of product categories ======
        // GET: UnicornController 
        public ActionResult Index()
        {
            return View();
        }

        // ====== TODO: As an admin user, I would like to see a list of the products assigned to a category on the category details page ======
        // ====== TODO: As an admin user, I would like a detail page for each product so that I can eventually edit its data or delete it ======
        // GET: UnicornController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnicornController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnicornController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // ====== TODO: As an admin user, I would like to view a detail page for each category so that I can eventually edit its data or delete it ======
        // GET: UnicornController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnicornController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UnicornController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnicornController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
