using Saber.Core;
using Saber.Vendor;

namespace Saber.Vendors.ResetCache
{
    public class WebsiteSettings : IVendorWebsiteSettings
    {
        public string Name { get; set; } = "Reset Cache";
        public string Render(IRequest request)
        {
            var settingsView = new View("/Vendors/ResetCache/resetcache.html");
            request.AddScript("/editor/js/vendors/resetcache/resetcache.js");
            return settingsView.Render();
        }
    }
}
