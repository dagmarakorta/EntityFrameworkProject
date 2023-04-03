using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProjectApp.Domain
{
    public class Samurai
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();
    }
}
