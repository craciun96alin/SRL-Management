using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class Tshirt : IIdentifier
    {
        public int TshirtID { get; set; }

        public int? ProviderID { get; set; }
        public int? AttributeTshirtsTypeID { get; set; }
        public int? AttributeColorID { get; set; }

        public Provider Provider { get; set; }
        public AttributeTshirtsType Type { get; set; }
        public AttributeColor Color { get; set; }

        [LocalizedDisplayName("Provider")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }
        [LocalizedDisplayName("Color")]
        public string ColorName => Color != null ? Color.Name : string.Empty;
        [LocalizedDisplayName("Sex")]
        public Enums.Sex Sex { get; set; }
        [LocalizedDisplayName("Size")]
        public Enums.TshirtSize Size { get; set; }
        [LocalizedDisplayName("Type")]
        public string TypeName => Type != null ? Type.Name : string.Empty;
        [LocalizedDisplayName("Stock")]
        public int Stock { get; set; }
        [LocalizedDisplayName("Rating")]
        public Enums.Rating Rating { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }
        public IList<TshirtOrder> _tshirtOrders { get; set; }

        //Used for the extension method, is ignored from the DB
        public int Id { get { return TshirtID; } }
    }
}
