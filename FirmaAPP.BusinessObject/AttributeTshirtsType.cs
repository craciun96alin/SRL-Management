using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class AttributeTshirtsType
    {
        public int AttributeTshirtsTypeID { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        public ICollection<Tshirt> Tshirts { get; set; }
    }
}
