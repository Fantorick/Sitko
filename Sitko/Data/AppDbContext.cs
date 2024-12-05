using Microsoft.EntityFrameworkCore;
using Sitko.Models;

namespace Sitko.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration configuration;
        public AppDbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"));
        }
        public DbSet<LineModel> lines { get; set; }
    }
}
