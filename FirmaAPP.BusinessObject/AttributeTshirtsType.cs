using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class AttributeTshirtsType
    {
        public int AttributeTshirtsTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Tshirt> Tshirts { get; set; }
    }
}
