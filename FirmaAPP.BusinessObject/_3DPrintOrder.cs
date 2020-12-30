using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class _3DPrintOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _3DPrintOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int _3DPrintID { get; set; }
        public _3DPrint _3DPrint { get; set; }

        public int? FilamentID { get; set; }

        public int Infill { get; set; }
        public Common.Enums._3DPrintQuality Quality { get; set; }
        public float Wheight { get; set; }
        public int PrintingTimeInMin { get; set; } // Will store the number of min

        public int PrintsQuantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
