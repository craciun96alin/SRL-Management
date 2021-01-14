using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class Attribute3DPrintsQuality
    {
        public int Attribute3DPrintsQualityID { get; set; }
        public string Name { get; set; }

        public IList<_3DPrintOrder> _3DPrintOrders { get; set; }

    }
}
