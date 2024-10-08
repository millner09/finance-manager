﻿using finance.manager.api.Shared.Models.Plaid;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace finance.manager.api.Shared.Networking
{
    public class PlaidApiClient : IPlaidApiClient
    {
        private readonly IConfiguration configuration;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly JsonSerializerOptions _jsonSerializerOptions = new(JsonSerializerDefaults.Web);

        public PlaidApiClient(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            this.configuration = configuration;
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<GetInstitutionsResult> GetAllInstitutions()
        {
            var httpClient = httpClientFactory.CreateClient();
            var getInstitutionsDto = new GetInstitutionsDto()
            {
                ClientId = configuration["Plaid:client_id"],
                Secret = configuration["Plaid:secret_key"],
                Count = 200,
                Offset = 0,
                CountryCodes = new List<string>
                {
                    "US"
                }
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post,
                $"{configuration["Plaid:url"]}/institutions/get");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var requestBody = JsonSerializer.Serialize(getInstitutionsDto, _jsonSerializerOptions);
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            using (var response = await httpClient.SendAsync(request))
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<GetInstitutionsResult>(stream, _jsonSerializerOptions) ?? new GetInstitutionsResult();
            }
        }

        public async Task<PlaidApiStatus> GetPlaidApiStatus()
        {
            var httpClient = httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(
                HttpMethod.Get,
               "https://status.plaid.com/api/v2/status.json");
            
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = await httpClient.SendAsync(request))
            {
                var stream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<PlaidApiStatus>(stream,
                   _jsonSerializerOptions) ?? new PlaidApiStatus();
            }
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
