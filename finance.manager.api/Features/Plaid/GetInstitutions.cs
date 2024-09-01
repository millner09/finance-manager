using finance.manager.api.Shared.Networking;

namespace finance.manager.api.Features.Plaid
{
    public static class GetInstitutions
    {
        public static void AddEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/plaid/institutions", async (IPlaidApiClient plaidApiClient) =>
            {
                var status = await plaidApiClient.GetAllInstitutions();
                return Results.Ok(status);
            });
        }
    }
}
