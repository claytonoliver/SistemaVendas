using Infraestrutura.Entidades.Parametro;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infraestrutura.DataBaseFactory
{
    public class SysDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ENA9A3U\SQLEXPRESS;Initial Catalog=Sistema;Integrated Security=True;Trust Server Certificate=True").LogTo(Console.WriteLine, LogLevel.Information); // Log para o console;
        }

        public DbSet<ParametroModel> Parametros { get; set; }
    }
}
