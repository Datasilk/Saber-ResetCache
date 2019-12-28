using Saber.Common.ProcessInfo;

namespace Saber.Vendor.ImportExport
{
    public class ResetCache : Controller, IVendorController
    {
        public override string Render(string body = "")
        {
            Server.Cache.Clear();
            ViewCache.cache.Clear();
            Gulp.Task("default");
            Gulp.Task("default:website");
            return "";
        }

        
    }
}
