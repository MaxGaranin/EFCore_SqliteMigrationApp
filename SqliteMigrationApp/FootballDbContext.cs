using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SqliteMigrationApp.Entities;

namespace SqliteMigrationApp
{
    public class MoviesDbContextFactory : IDesignTimeDbContextFactory<FootballDbContext>
    {
        FootballDbContext IDesignTimeDbContextFactory<FootballDbContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FootballDbContext>();
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlite(@"Data Source=FootballDb.db");

            return new FootballDbContext(optionsBuilder.Options);
        }
    }

    public class FootballDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Stadion> Stadions { get; set; }
        public DbSet<Team> Teams { get; set; }

        public FootballDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}