using Microsoft.AspNetCore.Builder;

namespace Gemography.APIs.Setups.Factory
{
    public static class SwaggerBuilderSetup
    {
        public static void SetupSwagger(this IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gemography Application"));
        }
    }
}
