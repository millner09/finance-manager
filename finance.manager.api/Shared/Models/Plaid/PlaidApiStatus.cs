using System.Text.Json;
using System.Text.Json.Serialization;

namespace finance.manager.api.Shared.Models.Plaid
{
    public class PlaidApiStatus
    {
        public PlaidPage Page { get; set; }
        public PlaidStatus Status { get; set; }

        public class PlaidPage
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
            
            [JsonPropertyName("time_zone")]
            public string TimeZone { get; set; }

            [JsonPropertyName("updated_at")]
            public DateTime UpdatedAt { get; set; }
        }

        public class PlaidStatus
        {
            public string Indicator { get; set; }
            public string Description { get; set; }
        }
    }
}
