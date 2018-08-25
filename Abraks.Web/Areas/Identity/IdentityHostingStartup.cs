using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Abraks.Web.Areas.Identity.IdentityHostingStartup))]
namespace Abraks.Web.Areas.Identity
{
    using Microsoft.AspNetCore.Hosting;
    
    public class IdentityHostingStartup
    {
        public class IdentityHostingStartUp : IHostingStartup
        {
            public void Configure(IWebHostBuilder builder)
            {
                builder.ConfigureServices((context, services) => { });
            }
        }
    }
}
