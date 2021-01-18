using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class AttributeVinylsType
    {
        public int AttributeVinylsTypeID { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        public IList<Vinyl> Vinyls { get; set; }

    }
}
