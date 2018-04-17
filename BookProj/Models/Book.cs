using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProj.Models
{
    public class Book
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public double Price { set; get; }
        public bool CheckedOut { set; get; }
    }
}
