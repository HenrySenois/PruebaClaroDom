using Microsoft.EntityFrameworkCore;

namespace PruebaClaroDom.Model.Models
{
    public class PruebaDbContext: DbContext
    {
        public PruebaDbContext(){}
        public PruebaDbContext(DbContextOptions<PruebaDbContext> options): base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
    }
}
