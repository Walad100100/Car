using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookProj.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookProj.Pages
{
    public class List2Model : PageModel
    {
        private readonly BookDbContext _context;

        public List2Model(BookDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return NotFound();
        }
    }
}