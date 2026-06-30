using FixTechMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FixTechMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Servico> Servicos { get; set; }
    }
}