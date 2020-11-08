using Saber.Core;

namespace Saber.Vendor.ImportExport
{
    public class ResetCache : Controller, IVendorController
    {
        public override string Render(string body = "")
        {
            Cache.Store.Clear();
            ViewCache.Clear();
            return "";
        }
    }
}
