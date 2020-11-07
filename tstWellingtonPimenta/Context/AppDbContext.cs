using Microsoft.EntityFrameworkCore;
using tstWellingtonPimenta.Models;

namespace tstWellingtonPimenta.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
