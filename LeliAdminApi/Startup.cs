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

            app.UseEndpoints(app => { app.MapControllerRoute(name:"default", pattern:"{controller=Home}/{action=Index}/{id?}"); }); 
        }
    }
}
