using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class _3DDesignOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _3DDesignOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        
        public int _3DDesignID { get; set; }
        public _3DDesign _3DDesign { get; set; }

        public string Description { get; set; }
        public float Price { get; set; }
    }
}
