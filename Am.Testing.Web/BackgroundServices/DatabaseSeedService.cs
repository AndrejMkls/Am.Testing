using Am.Testing.App.Database.Main;
using Am.Testing.App.Seeding;
using Am.Testing.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Radzen;

namespace Am.Testing.Web.BackgroundServices
{
    public class DatabaseSeedService(ILogger<DatabaseSeedService> logger, IServiceScopeFactory scopeFactory) : BackgroundService
    {
        private readonly ILogger _logger = logger;
        private readonly IServiceScopeFactory _scopeFactory = scopeFactory;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                using var scope = _scopeFactory.CreateScope();

                var dbContext = scope.ServiceProvider.GetRequiredService<MainDbContext>();
                if (dbContext is null)
                {
                    return;
                }

                var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                if (appContext is null)
                {
                    return;
                }

                await dbContext.Database.MigrateAsync();
                await appContext.Database.MigrateAsync();

                /*
                 *   CREATE DATABASE FOR THE FIRST TIME. 
                 */
                //await dbContext.Database.EnsureCreatedAsync(stoppingToken);

                /*
                *   CREATE SUPER USER 
                */
                //var accountService = scope.ServiceProvider.GetRequiredService<IAccountService>();
                //if (accountService is null)
                //{
                //    return;
                //}

                var users = await appContext.Users.ToListAsync(stoppingToken);
                if (users is null || users.Any() == false)
                {
                    await CreateSuperUser(appContext);
                    users = await appContext.Users.ToListAsync(stoppingToken);
                }

                var superUser = users?.FirstOrDefault(x => x.NormalizedUserName == "SUPERADMIN");

                if (superUser is null)
                {
                    return;
                }

                await CreateCoverTypes(dbContext, superUser, stoppingToken);
                await CreateGenres(dbContext, superUser, stoppingToken);


            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to seed database, due error: {err}", ex);
            }
        }

        private async Task CreateSuperUser(ApplicationDbContext context)
        {
            _logger.LogInformation("Creating first user, superadministrator");

            var user = new ApplicationUser()
            {
                Email = "superadmin@am.testing.sk",
                UserName = "Super Admin",
                NormalizedUserName = "SUPERADMIN",
                LockoutEnabled = false,
                
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }


        private async Task CreateCoverTypes(MainDbContext context, ApplicationUser superUser, CancellationToken cancellationToken)
        {
            var hasItems = await context.CoverTypes.AnyAsync(cancellationToken);

            if (!hasItems)
            {
                var seeding = new CoverTypeSeeding();
                var items = seeding.Items;

                foreach (var item in items)
                {
                    item.CreatedBy = superUser.Id;
                    item.CreatedAt = DateTime.UtcNow;
                }

                await context.CoverTypes.AddRangeAsync(items, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

        private async Task CreateGenres(MainDbContext context, ApplicationUser superUser, CancellationToken cancellationToken)
        {
            var hasItems = await context.Genres.AnyAsync(cancellationToken);

            if (!hasItems)
            {
                var seeding = new GenreSeeding();
                var items = seeding.Items;

                foreach (var item in items)
                {
                    item.CreatedBy = superUser.Id;
                    item.CreatedAt = DateTime.UtcNow;
                }

                await context.Genres.AddRangeAsync(items, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

    }
}
