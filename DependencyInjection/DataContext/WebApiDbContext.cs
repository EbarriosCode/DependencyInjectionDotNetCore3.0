using DependencyInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.DataContext
{
    public class WebApiDbContext : DbContext
    {
        public WebApiDbContext() { }

        public WebApiDbContext(DbContextOptions<WebApiDbContext> options)
            :base(options)
        {
        }

        public DbSet<Album> Albumes { get; set; }
        public DbSet<Artista> Artistas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("DependencyInjection_DB");
        }
    }
}
