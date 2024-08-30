using finance.manager.api.Shared.Networking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finance.manager.api.tests.Shared.Networking
{
    public class PlaidApiClientTests
    {

        [Fact]
        public void GetClientIdAndTokenWorksAsExpected()
        {
            //Arrange
            var clientSecret = "client_secret";
            var clientId = "client_id";

            var inMemorySettings = new Dictionary<string, string> {
                {"Plaid:client_id", clientId},
                {"Plaid:client_secret", clientSecret}
             };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            // arrange
            var plaidApiClient = new PlaidApiClient(configuration);

            // act
            var credentials = plaidApiClient.GetPlaidCredentials();

            // assert
            Assert.Equal(clientId, credentials.ClientId);
            Assert.Equal(clientSecret, credentials.ClientSecret);
        }
    }
}
