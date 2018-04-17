using CarProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Car.Data
{
    public class PersonDbContext:DbContext
    {
        public DbSet<Person> Cars { set; get; }

        public PersonDbContext(DbContextOptions options) :base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
