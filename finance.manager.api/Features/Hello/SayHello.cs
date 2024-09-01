namespace finance.manager.api.Features.Hello
{
    public static class SayHello
    {
        public static void AddEndpoint(IEndpointRouteBuilder app)
        {
            app.MapGet("/hello", () =>
            {
                return Results.Ok("Hello, world!");
            });
        }
    }
}
