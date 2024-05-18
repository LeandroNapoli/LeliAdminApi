using Microsoft.AspNetCore.Builder;

namespace LeliAdminApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
        }
    }
}
