using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProjectApp.Domain
{
    public class Quote
    {
        public string? Id { get; set; }
        public string? Text { get; set; }
        public Samurai Samurai { get; set; } = new Samurai();

        public int? SamuraiId { get; set; }
    }
}
