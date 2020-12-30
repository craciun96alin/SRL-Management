using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Quantity { get; set; }
        public short PrintingType { get; set; }
        public float TotalPrice { get; set; }     
    }
}
