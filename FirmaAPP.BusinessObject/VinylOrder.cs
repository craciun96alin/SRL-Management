using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public float Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
