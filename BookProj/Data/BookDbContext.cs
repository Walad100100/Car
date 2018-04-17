using BookProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProj.Data
{
    public class BookDbContext: DbContext
    {
        public DbSet<Book> Books { set; get; }

        public BookDbContext(DbContextOptions options): base(options)
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }

    }
}
