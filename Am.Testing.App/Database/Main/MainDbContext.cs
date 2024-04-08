using Am.Testing.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Am.Testing.App.Database.Main
{
    public class MainDbContext(IConfiguration configuration) : DbContext
    {
        protected readonly IConfiguration _configuration = configuration;

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                _configuration.GetConnectionString("DefaultConnection")
                , b => b.MigrationsAssembly("Am.Testing.Web")
                );
        
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            if (Debugger.IsAttached)
            {
                optionsBuilder.EnableDetailedErrors();
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

    }
}
