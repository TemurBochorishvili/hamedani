using Hamedani.Models;
using Microsoft.EntityFrameworkCore;

namespace Hamedani
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Feature> Features { get; set; }
    }
}