using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class AttributeVinylsType
    {
        public int AttributeVinylsTypeID { get; set; }
        public string Name { get; set; }

        public IList<Vinyl> Vinyls { get; set; }

    }
}
