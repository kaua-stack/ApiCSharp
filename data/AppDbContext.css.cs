using Microsoft.EntityFrameworkCore;
using projetoDBZ.models;

namespace projetoDBZ.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Personagem> DBZ { get; set; }
    }
}