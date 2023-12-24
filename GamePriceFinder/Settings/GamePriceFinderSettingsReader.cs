namespace GamePriceFinder.Settings
{
    public static class GamePriceFinderSettingsReader
    {
        public static GamePriceFinderSettings Read(IConfiguration configuration)
        {
            return new GamePriceFinderSettings()
            {
                ServiceUri = configuration.GetValue<Uri>("Uri"),
                GamePriceFinderDbContextConnectionString = configuration.GetValue<string>("GamePriceFinderDbContext"),
                IdentityServerUri = configuration.GetValue<string>("IdentityServerSettings:Uri"),
                ClientId = configuration.GetValue<string>("IdentityServerSettings:ClientId"),
                ClientSecret = configuration.GetValue<string>("IdentityServerSettings:ClientSecret"),
            };
        }
    }
}