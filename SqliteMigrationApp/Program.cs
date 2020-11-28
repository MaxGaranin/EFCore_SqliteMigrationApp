using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SqliteMigrationApp.Entities;

namespace SqliteMigrationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            Console.WriteLine($"Hello {connectionString}");

            var builder = new DbContextOptionsBuilder<FootballDbContext>();
            builder
                .UseLazyLoadingProxies()
                .UseSqlite(connectionString);

            using (var context = new FootballDbContext(builder.Options))
            {
                context.Database.Migrate();

                var coach = new Coach
                {
                    FirstName = "Ivan",
                    LastName = "Petrov",
                    City = "Samara",
                };

                context.Coaches.Add(coach);
                context.SaveChanges();
            }

            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}