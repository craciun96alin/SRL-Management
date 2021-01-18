using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class OtherPurchase
    {
        public int OtherPurchaseID { get; set; }

        public int? ProviderID { get; set; }
        public Provider Provider { get; set; }
        [LocalizedDisplayName("Provider")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }
        [LocalizedDisplayName("Stock")]
        public float? Stock { get; set; }
        [LocalizedDisplayName("Rating")]
        public Enums.Rating Rating { get; set; }

        public IList<OtherPurchaseOrder> _otherPurchaseOrders { get; set; }

    }
}
