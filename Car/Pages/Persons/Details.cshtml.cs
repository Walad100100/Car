using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Car.Data;
using CarProj.Models;

namespace PersonProj.Pages.Persons
{
    public class DetailsModel : PageModel
    {
        private readonly Car.Data.PersonDbContext _context;

        public DetailsModel(Car.Data.PersonDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _context.Cars.SingleOrDefaultAsync(m => m.id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
