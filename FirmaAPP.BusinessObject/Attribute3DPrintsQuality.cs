using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class Attribute3DPrintsQuality
    {
        public int Attribute3DPrintsQualityID { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        public IList<_3DPrintOrder> _3DPrintOrders { get; set; }

    }
}
