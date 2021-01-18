using FirmaAPP.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaAPP.BusinessObject
{
    public class OtherPurchaseOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OtherPurchaseOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int OtherPurchaseID { get; set; }
        public OtherPurchase OtherPurchase { get; set; }

        [LocalizedDisplayName("Quantity")]
        public float Quantity { get; set; }
        [LocalizedDisplayName("TotalPrice")]
        public float TotalPrice { get; set; }
    }
}
