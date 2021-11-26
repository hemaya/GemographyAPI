using Gemography.APIs;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Gemography.UnitTest.Factory
{
    public class MyReaderApiAppFactory : WebApplicationFactory<Startup>
{
	protected override IWebHostBuilder CreateWebHostBuilder()
	{
		return WebHost.CreateDefaultBuilder()
			.UseStartup<Startup>();
	}
}
}
