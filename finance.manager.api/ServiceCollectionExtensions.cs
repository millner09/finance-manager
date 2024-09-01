using finance.manager.api.Shared.Networking;
using System.Reflection;

namespace finance.manager.api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPlaidApiClient, PlaidApiClient>();
            var currentAssembly = Assembly.GetExecutingAssembly();
            // services.AddAutoMapper(currentAssembly);
            return services;
        }

        public static IServiceCollection RegisterPersistenceServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            //services.AddDbContext<TravelInspirationDbContext>(options =>
            //    options.UseSqlServer(
            //        configuration.GetConnectionString("TravelInspirationDbConnection")));
            return services;
        }
    }
}
