using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance
{
    internal class DataContext : DbContext
    {
        public DbSet<User> Users { get ; }

        public DataContext(DbContextOptions<DataContext> dbOptions) : base(dbOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(DataContext).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
