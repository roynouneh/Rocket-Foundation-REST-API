using Microsoft.EntityFrameworkCore;

namespace Interventions.Models
{
    public class MySqlConnectionContext : DbContext
    {
        public MySqlConnectionContext (DbContextOptions<MySqlConnectionContext> options)
            : base(options)
        {
        }

        public DbSet<Intervention> interventions { get; set; }

    }
}