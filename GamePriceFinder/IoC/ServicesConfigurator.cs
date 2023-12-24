using GamePriceFinder.BL.Auth;
using GamePriceFinder.DataAccess.Entities;
using GamePriceFinder.DataAccess.Repositories;
using GamePriceFinder.Settings;
using Microsoft.AspNetCore.Identity;

namespace GamePriceFinder.IoC
{
    public static class ServicesConfigurator
    {
        public static void ConfigureService(IServiceCollection services, GamePriceFinderSettings settings)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAuthProvider>(x =>
                new AuthProvider(x.GetRequiredService<SignInManager<User>>(),
                    x.GetRequiredService<UserManager<User>>(),
                    x.GetRequiredService<IHttpClientFactory>(),
                    settings.IdentityServerUri,
                    settings.ClientId,
                    settings.ClientSecret));
        }
    }
}
