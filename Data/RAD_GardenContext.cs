using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAD_Garden.Models;

namespace RAD_Garden.Data
{
    public class RAD_GardenContext : DbContext
    {
        public RAD_GardenContext (DbContextOptions<RAD_GardenContext> options)
            : base(options)
        {
        }

        public DbSet<RAD_Garden.Models.Flower> Flower { get; set; } = default!;
    }
}
