using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class AppSettings
    {
        public int AppSettingsID { get; set; }
        [LocalizedDisplayName("BillFolder")]
        public string BillFolder { get; set; }
        [LocalizedDisplayName("_3DDesignFolder")]
        public string _3DDesignFolder { get; set; }
        [LocalizedDisplayName("_3DPrintFolder")]
        public string _3DPrintFolder { get; set; }
        public int UserID { get; set; }
        public User _user { get; set; }
    }
}
