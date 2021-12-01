[assembly: HostingStartup(typeof(TheForum.NET.Areas.Identity.IdentityHostingStartup))]
namespace TheForum.NET.Areas.Identity
{
    public class IdentityHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
