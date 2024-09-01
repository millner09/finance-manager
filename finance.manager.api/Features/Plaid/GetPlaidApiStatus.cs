using finance.manager.api.Shared.Networking;

namespace finance.manager.api.Features.Plaid
{
    public static class GetPlaidApiStatus
    {
        public static void AddEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/plaid-api-status", async (IPlaidApiClient plaidApiClient) =>
            {
                var status = await plaidApiClient.GetPlaidApiStatus();
                return Results.Ok(status);
            });
        }
    }
}
