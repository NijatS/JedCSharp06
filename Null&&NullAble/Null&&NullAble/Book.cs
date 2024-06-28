using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null__NullAble
{
    internal class Book
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Author { get; set; }
        public double Price { get; set; } 
    }
}
