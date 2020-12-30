using FirmaAPP.Common;
using System.Collections.Generic;
using System.ComponentModel;

namespace FirmaAPP.BusinessObject
{
    public class OtherPurchase
    {
        public int OtherPurchaseID { get; set; }

        public int? ProviderID { get; set; }
        public Provider Provider { get; set; }
        [DisplayName("Furnizor")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        public string Name { get; set; } 
        public string Description { get; set; }
        public float? Stock { get; set; }
        public Enums.Rating Rating { get; set; }

        public IList<OtherPurchaseOrder> _otherPurchaseOrders { get; set; }

    }
}
