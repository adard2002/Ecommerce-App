using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Identity;
using WebApplication1.Services.Identity;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterData data)
        {
            await userService.Register(data, ModelState);
            if (!ModelState.IsValid)
            {
                return View(data);
            }

            return RedirectToAction(nameof(Welcome));
        }

        [HttpGet("Welcome")]
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
