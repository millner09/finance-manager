namespace finance.manager.api.Shared.Models.Plaid
{
    public class PlaidApiStatus
    {
        public Page page { get; set; }
        public Status status { get; set; }

        public class Page
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string time_zone { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Status
        {
            public string indicator { get; set; }
            public string description { get; set; }
        }

    }
}
