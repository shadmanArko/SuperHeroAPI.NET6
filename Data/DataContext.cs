using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)  //todo need an explanation
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
