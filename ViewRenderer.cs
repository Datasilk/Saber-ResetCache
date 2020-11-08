using Saber.Core;

namespace Saber.Vendor.ResetCache
{
    [ViewPath("/Views/AppSettings/appsettings.html")]
    public class ViewRenderer : IVendorViewRenderer
    {
        public string Render(IRequest request, View view)
        {
            var settingsView = new View("/Vendors/ResetCache/resetcache.html");
            request.AddScript("/editor/js/vendors/resetcache/resetcache.js");
            return settingsView.Render();
        }
    }
}
