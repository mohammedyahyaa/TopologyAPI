using Microsoft.EntityFrameworkCore;
using TopologyAPI.Models;

namespace TopologyAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<RootComponent> Components { get; set; }
       
    }
}
