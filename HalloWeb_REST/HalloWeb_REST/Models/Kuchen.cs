using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalloWeb_REST.Models
{
    public class Kuchen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bewertung { get; set; }
        public bool Schoko { get; set; }
    }
}
