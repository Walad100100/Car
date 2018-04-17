﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookProj.Data;
using BookProj.Models;

namespace BookProj.Pages
{
    public class Edit2Model : PageModel
    {
        private readonly BookProj.Data.BookDbContext _context;

        public Edit2Model(BookProj.Data.BookDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGetAsync(int? id)
        {
            if (id == null)
            {
                //return NotFound();
            }

            Book = await _context.Books.SingleOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                //return NotFound();
            }
            //return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(Book.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
