using System.Collections.Generic;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class Vinyl
    {
        public int VinylID { get; set; }

        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        public int? ProviderID { get; set; }
        public int? AttributeVinylsTypeID { get; set; }
        public int? AttributeColorID { get; set; }

        public Provider Provider { get; set; }
        public AttributeColor Color { get; set; }
        public AttributeVinylsType Type { get; set; }

        [LocalizedDisplayName("Provider")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [LocalizedDisplayName("Type")]
        public string TypeName => Type != null ? Type.Name : string.Empty;
        [LocalizedDisplayName("Color")]
        public string ColorName => Color != null ? Color.Name : string.Empty;
        [LocalizedDisplayName("Stock")]
        public float Stock { get; set; }
        [LocalizedDisplayName("Rating")]
        public Enums.Rating Rating { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }

        public IList<VinylOrder> _vinylOrders { get; set; }
    }
}
