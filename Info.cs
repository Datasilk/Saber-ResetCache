using Saber.Vendor;

namespace Saber.Vendors.ResetCache
{
    public class Info : IVendorInfo
    {
        public string Key { get; set; } = "ResetCache";
        public string Name { get; set; } = "Reset Cache";
        public string Description { get; set; } = "Allows administrators to clear all in-memory cached objects related to web pages, such as HTML files, multi-lingual content JSON files, and page settings JSON files.";
        public string Icon { get; set; }
        public Vendor.Version Version { get; set; } = "1.0.0.0";
    }
}
