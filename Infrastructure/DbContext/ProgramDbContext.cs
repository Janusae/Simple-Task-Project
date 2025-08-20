using Domain.SQLite;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public class ProgramDbContext : DbContext
    {
        public ProgramDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
