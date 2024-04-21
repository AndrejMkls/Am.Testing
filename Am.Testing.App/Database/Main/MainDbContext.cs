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

        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Publisher)
                .WithMany()
                .HasForeignKey(e => e.PublisherId);

            modelBuilder.Entity<Book>()
                .HasOne(e => e.CoverType)
                .WithMany()
                .HasForeignKey(e => e.CoverTypeId);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Authors)
                .WithMany(e => e.Books)
                .UsingEntity<BookAuthor>(
                    left => left.HasOne(e => e.Author).WithMany().HasForeignKey(e => e.AuthorId),
                    right => right.HasOne(e => e.Book).WithMany().HasForeignKey(e =>e.BookId)
                );

            modelBuilder.Entity<Book>()
               .HasMany(e => e.Genres)
               .WithMany()
               .UsingEntity<BookGenre>(
                   left => left.HasOne(e => e.Genre).WithMany().HasForeignKey(e => e.GenreId),
                   right => right.HasOne(e => e.Book).WithMany().HasForeignKey(e => e.BookId)
               );



            ApplySoftDelete(modelBuilder);
        }

        private static void ApplySoftDelete(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasQueryFilter(x => x.DeletedBy == null);
            modelBuilder.Entity<Book>().HasQueryFilter(x => x.DeletedBy == null);
            modelBuilder.Entity<Genre>().HasQueryFilter(x => x.DeletedBy == null);
            modelBuilder.Entity<CoverType>().HasQueryFilter(x => x.DeletedBy == null);
            modelBuilder.Entity<Publisher>().HasQueryFilter(x => x.DeletedBy == null);

            modelBuilder.Entity<BookGenre>().HasQueryFilter(x => x.DeletedBy == null);
            modelBuilder.Entity<BookAuthor>().HasQueryFilter(x => x.DeletedBy == null);
        }
    }
}
