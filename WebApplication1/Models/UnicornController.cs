using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UnicornController : Controller
    {
        // GET: UnicornController
        public ActionResult Index()
        {
            return View();
        }

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
