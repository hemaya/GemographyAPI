using Microsoft.AspNetCore.Builder;

namespace Gemography.APIs.Setups.Factory
{
    public static class EndpointBuilderSetup
    {
        public static void SetupEndpointBuilder(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
