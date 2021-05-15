using Microsoft.EntityFrameworkCore;
using Skinet.Library.Entities;

namespace Skinet.Infrastructure.Data
{
    public class StoreContext : DbContext
    {

        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
