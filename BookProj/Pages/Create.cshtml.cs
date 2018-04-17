using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookProj.Data;
using BookProj.Models;

namespace BookProj.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BookProj.Data.BookDbContext _context;

        public CreateModel(BookProj.Data.BookDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            //return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}