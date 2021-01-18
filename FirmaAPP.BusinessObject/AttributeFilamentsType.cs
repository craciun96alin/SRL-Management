using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class AttributeFilamentsType
    {
        public int AttributeFilamentsTypeID { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        public ICollection<Filament> Filaments { get; set; }
    }

}
