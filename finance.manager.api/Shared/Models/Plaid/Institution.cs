namespace finance.manager.api.Shared.Models.Plaid
{
    public class Institution
    {
        public List<string> country_codes { get; set; }
        public string institution_id { get; set; }
        public string name { get; set; }
        public List<string> products { get; set; }
        public List<string> routing_numbers { get; set; }
        public List<string> dtc_numbers { get; set; }
        public bool oauth { get; set; }
        public Status status { get; set; }

        public class Auth
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class Breakdown
        {
            public double success { get; set; }
            public double error_plaid { get; set; }
            public double error_institution { get; set; }
            public string refresh_interval { get; set; }
        }

        public class Identity
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class Investments
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
            public Liabilities liabilities { get; set; }
        }

        public class InvestmentsUpdates
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class ItemLogins
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class Liabilities
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class LiabilitiesUpdates
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class Status
        {
            public ItemLogins item_logins { get; set; }
            public TransactionsUpdates transactions_updates { get; set; }
            public Auth auth { get; set; }
            public Identity identity { get; set; }
            public Investments investments { get; set; }
            public InvestmentsUpdates investments_updates { get; set; }
            public LiabilitiesUpdates liabilities_updates { get; set; }
        }

        public class TransactionsUpdates
        {
            public string status { get; set; }
            public DateTime last_status_change { get; set; }
            public Breakdown breakdown { get; set; }
        }


    }
}
