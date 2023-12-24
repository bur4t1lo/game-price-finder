namespace GamePriceFinder.Settings
{
    public class GamePriceFinderSettings
    {
        public Uri ServiceUri { get; set; }
        public string GamePriceFinderDbContextConnectionString { get; set; }
        public string IdentityServerUri { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
