using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HalloWeb_REST.Models
{
    public class KuchenContext : DbContext
    {
        public KuchenContext (DbContextOptions<KuchenContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<HalloWeb_REST.Models.Kuchen> Kuchen { get; set; }
    }
}
