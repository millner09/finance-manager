using finance.manager.api.Shared.Models.Plaid;

namespace finance.manager.api.Shared.Networking
{
    public class PlaidApiClient : IPlaidApiClient
    {
        private readonly IConfiguration configuration;

        public PlaidApiClient(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public ClientCredentials GetPlaidCredentials()
        {
            var clientCredentials = new ClientCredentials()
            {
                ClientId = configuration["Plaid:client_id"] ?? string.Empty,
                ClientSecret = configuration["Plaid:client_secret"] ?? string.Empty
            };

            return clientCredentials;
        }
    }
}
