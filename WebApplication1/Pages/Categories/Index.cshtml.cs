using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.AppDbContext _context;

        public IndexModel(WebApplication1.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Category> Categories { get;set; }

        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
        }
    }
}
