using FirmaAPP.Common;
using System.Collections.Generic;
using System.ComponentModel;

namespace FirmaAPP.BusinessObject
{
    public class AppSettings
    {
        public int AppSettingsID { get; set; }

        public string BillFolder { get; set; }
        public string _3DDesignFolder { get; set; }
        public string _3DPrintFolder { get; set; }
        public int UserID { get; set; }
        public User _user { get; set; }
    }
}
