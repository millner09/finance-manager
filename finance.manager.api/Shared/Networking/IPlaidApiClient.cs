using finance.manager.api.Shared.Models.Plaid;

namespace finance.manager.api.Shared.Networking
{
    public interface IPlaidApiClient
    {
        Task<PlaidApiStatus> GetPlaidApiStatus();
        ClientCredentials GetPlaidCredentials();
    }
}
