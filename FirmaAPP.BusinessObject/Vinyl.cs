using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class Vinyl
    {
        public int VinylID { get; set; }
        [DisplayName("Nume")]
        public string Name { get; set; }
        public int? ProviderID { get; set; }
        public Provider Provider { get; set; }
        [DisplayName("Furnizor")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [DisplayName("Tip")]
        public Enums.VinylType Type { get; set; }
        [DisplayName("Culoare")]
        public Enums.Color Color { get; set; }
        [DisplayName("Stoc(metrii)")]
        public float Stock { get; set; }

        public Enums.Rating Rating { get; set; }
        public string Description { get; set; }

        public IList<VinylOrder> _vinylOrders { get; set; }
    }
}
