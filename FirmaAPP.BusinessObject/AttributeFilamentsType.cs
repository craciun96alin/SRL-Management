using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class AttributeFilamentsType
    {
        public int AttributeFilamentsTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Filament> Filaments { get; set; }
    }

}
