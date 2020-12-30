using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public float Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
