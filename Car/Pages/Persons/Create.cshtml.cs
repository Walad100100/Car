using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Car.Data;
using CarProj.Models;

namespace PersonProj.Pages.Persons
{
    public class CreateModel : PageModel
    {
        private readonly Car.Data.PersonDbContext _context;

        public CreateModel(Car.Data.PersonDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        
        public Person MyPerson { get; set; }

        public async Task<IActionResult> OnPostAsync(Person person)
        {
            MyPerson = person;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cars.Add(MyPerson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}