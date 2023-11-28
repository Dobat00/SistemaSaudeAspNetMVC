using Microsoft.EntityFrameworkCore;
using SistemaSaudeAspNetMVC.Models;

namespace SistemaSaudeAspNetMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<Cliente> Clientes { get; set;}
    }
}
