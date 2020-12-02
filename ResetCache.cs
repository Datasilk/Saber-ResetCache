using Saber.Vendor;

namespace Saber.Vendors.ImportExport
{
    public class ResetCache : Controller, IVendorController
    {
        public override string Render(string body = "")
        {
            if (!CheckSecurity()) { return AccessDenied();  }
            Cache.Store.Clear();
            ViewCache.Clear();
            return "";
        }
    }
}
