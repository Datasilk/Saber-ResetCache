namespace Saber.Vendor.ResetCache
{
    [ViewPath("/Views/AppSettings/appsettings.html")]
    public class ViewRenderer : IVendorViewRenderer
    {
        public void Render(Request request, View view)
        {
            var settingsView = new View("/Vendor/ResetCache/resetcache.html");
            request.AddScript("/js/vendor/resetcache/resetcache.js");
            view["vendor"] += settingsView.Render();
        }
    }
}
