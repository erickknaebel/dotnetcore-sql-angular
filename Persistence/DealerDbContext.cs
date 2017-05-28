using DealerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DealerApp.Persistence
{
    public class DealerDbContext : DbContext
    {
        public DealerDbContext(DbContextOptions<DealerDbContext> options)
        : base(options)
        {
           
        }

         public DbSet<Make> Makes { get; set; }

         public DbSet<Model> Models { get; set; }
    }
}