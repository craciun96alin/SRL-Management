using FirmaAPP.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaAPP.BusinessObject
{
    public class VinylOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VinylOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int VinylID { get; set; }
        public Vinyl Vinyl { get; set; }

        [LocalizedDisplayName("Quantity")]
        public float Quantity { get; set; }
        [LocalizedDisplayName("TotalPrice")]
        public float TotalPrice { get; set; }
    }
}
