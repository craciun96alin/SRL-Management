using FirmaAPP.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaAPP.BusinessObject
{
    public class _3DPrintOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _3DPrintOrderID { get; set; }
        public int? Attribute3DPrintsQualityID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int _3DPrintID { get; set; }
        public _3DPrint _3DPrint { get; set; }

        public int? FilamentID { get; set; }

        [LocalizedDisplayName("Infill")]
        public int Infill { get; set; }
        public Attribute3DPrintsQuality PrintQuality { get; set; }
        [LocalizedDisplayName("Wheight")]
        public float Wheight { get; set; }
        [LocalizedDisplayName("PrintingTimeInMin")]
        public int PrintingTimeInMin { get; set; } // Will store the number of min
        [LocalizedDisplayName("Quantity")]
        public int PrintsQuantity { get; set; }
        [LocalizedDisplayName("TotalPrice")]
        public float TotalPrice { get; set; }
    }
}
