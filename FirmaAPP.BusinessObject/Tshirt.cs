using FirmaAPP.Common;
using System.Collections.Generic;
using System.ComponentModel;

namespace FirmaAPP.BusinessObject
{
    public class Tshirt
    {
        public int TshirtID { get; set; }

        public int? ProviderID { get; set; }

        public Provider Provider { get; set; }
        [DisplayName("Furnizor")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [DisplayName("Nume")]
        public string Name { get; set; }
        [DisplayName("Culoare")]
        public Enums.Color Color { get; set; }
        [DisplayName("Sex")]
        public Enums.Sex Sex { get; set; }
        [DisplayName("Mărime")]
        public Enums.TshirtSize Size { get; set; }
        [DisplayName("Tip")]
        public Enums.TshirtType Type { get; set; }
        [DisplayName("Stoc")]
        public int Stock { get; set; }
        public Enums.Rating Rating { get; set; }
        public string Description { get; set; }
        public IList<TshirtOrder> _tshirtOrders { get; set; }
    }
}
