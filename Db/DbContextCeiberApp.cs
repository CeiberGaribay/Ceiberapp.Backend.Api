using Ceiberapp.Backend.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Ceiberapp.Backend.Api.Db
{
    public class DbContextCeiberApp : DbContext
    {
        public DbContextCeiberApp(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer();    
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}



