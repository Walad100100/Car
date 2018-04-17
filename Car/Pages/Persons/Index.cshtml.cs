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
    public class IndexModel : PageModel
    {
        private readonly Car.Data.PersonDbContext _context;

        public IndexModel(Car.Data.PersonDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Cars.ToListAsync();
        }
    }
}
