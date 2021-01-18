using FirmaAPP.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaAPP.BusinessObject
{
    public class FilamentOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilamentOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int FilamentID { get; set; }
        public Filament Filament { get; set; }

        [LocalizedDisplayName("Quantity")]
        public float Quantity { get; set; }
        [LocalizedDisplayName("TotalPrice")]
        public float TotalPrice { get; set; }
    }
}
