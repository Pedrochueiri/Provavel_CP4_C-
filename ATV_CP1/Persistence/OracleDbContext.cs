using ATV_CP1.Models;
using Microsoft.EntityFrameworkCore;

namespace ATV_CP1.Persistence
{
    public class OracleDbContext: DbContext
    {
        public DbSet<Roupas> Roupas { get; set; }

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) 
        {
            
        }

    }
}
