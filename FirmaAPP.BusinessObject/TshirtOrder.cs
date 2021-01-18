using FirmaAPP.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaAPP.BusinessObject
{
    public class TshirtOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TshirtOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int TshirtID { get; set; }
        public Tshirt Tshirt { get; set; }

        [LocalizedDisplayName("Quantity")]
        public int Quantity { get; set; }
        [LocalizedDisplayName("Type")]
        public short PrintingType { get; set; }
        [LocalizedDisplayName("TotalPrice")]
        public float TotalPrice { get; set; }
    }
}
