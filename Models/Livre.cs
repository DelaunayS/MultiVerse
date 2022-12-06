using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLibrary.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author {get; set; }
        public int Year { get  ; set; }
        public decimal Price { get; set; }
    }
}