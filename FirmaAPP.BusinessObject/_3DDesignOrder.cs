using FirmaAPP.Common;
using System.ComponentModel.DataAnnotations.Schema;

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
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }
        [LocalizedDisplayName("Price")]
        public float Price { get; set; }
    }
}
