using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookProj.Data;
using BookProj.Models;

namespace BookProj.Pages
{
    public class Index2Model : PageModel
    {
        private readonly BookProj.Data.BookDbContext _context;

        public Index2Model(BookProj.Data.BookDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
