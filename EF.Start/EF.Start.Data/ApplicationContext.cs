using Microsoft.EntityFrameworkCore;

namespace EF.Start.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Toggle> Toggles => Set<Toggle>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = " +
                "C:/Users/n1kko/source/repos/EF.Start/FeatureToggles.db");
        }
    }
}