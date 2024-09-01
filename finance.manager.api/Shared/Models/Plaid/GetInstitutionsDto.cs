using System.Text.Json.Serialization;

namespace finance.manager.api.Shared.Models.Plaid
{
    public class GetInstitutionsDto
    {
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public int Count { get; set; }
        public int Offset { get; set; }

        [JsonPropertyName("country_codes")]
        public List<string> CountryCodes { get; set; }
    }
}
