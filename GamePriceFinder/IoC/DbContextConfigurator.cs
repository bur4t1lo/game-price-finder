using GamePriceFinder.DataAccess;
using GamePriceFinder.Settings;
using Microsoft.EntityFrameworkCore;

namespace GamePriceFinder.IoC
{
    public static class DbContextConfigurator
    {
        public static void ConfigureService(IServiceCollection services, GamePriceFinderSettings settings)
        {
            services.AddDbContextFactory<GamePriceFinderDbContext>(
                options => { options.UseSqlServer(settings.GamePriceFinderDbContextConnectionString); },
                ServiceLifetime.Scoped);
        }

        public static void ConfigureApplication(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<GamePriceFinderDbContext>>();
            using var context = contextFactory.CreateDbContext();
            context.Database.Migrate(); //makes last migrations to db and creates database if it doesn't exist
        }
    }
}
