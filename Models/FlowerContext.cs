using Microsoft.EntityFrameworkCore;

namespace RAD_Garden.Models
{
    public class FlowerContext : DbContext
    {
        public FlowerContext(DbContextOptions<FlowerContext> options) : base(options)
        {
        }

        public DbSet<Flower> Flowers { get; set; }
    }

}
