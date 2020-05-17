namespace Saber.Vendor.ResetCache
{
    [ViewPath("/Views/AppSettings/appsettings.html")]
    public class ViewRenderer : IVendorViewRenderer
    {
        public string Render(Request request, View view)
        {
            var settingsView = new View("/Vendor/ResetCache/resetcache.html");
            request.AddScript("/editor/js/vendor/resetcache/resetcache.js");
            return settingsView.Render();
        }
    }
}
