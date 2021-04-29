using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            var products = new[]{
                new Product
                {
                    Id = 1,
                    Name = "Charlie the unicorn",
                },
                new Product
                {
                    Id = 2,
                    Name = "Lucas the spider",
                },
            };
            return View(products);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {

            var product = new Product
            {
                Id = id,
                Name = "Uhhhhh",
            };

            return base.View(product);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Name")] Product product)
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

        // GET: HomeController1/Edit/5
        public IActionResult Edit(int id)
        {

            var product = new Product
            {
                Id = id,
                Name = "Edit this and stuff",
            };
            return View(product);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
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



        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            var product = new Product
            {
                Id = id,
                Name = "Delete this and stuff",
            };
            return View();
        }

        // POST: HomeController1/Delete/5
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
