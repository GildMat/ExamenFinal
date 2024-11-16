using Microsoft.EntityFrameworkCore;
using apiexamen.Models;

namespace apiexamen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<InformacionGeneral> InformacionGeneral { get; set; }
    }
}
