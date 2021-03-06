﻿using FirmaAPP.Common;
using System.Collections.Generic;

namespace FirmaAPP.BusinessObject
{
    public class AttributeColor
    {
        public int AttributeColorID { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }

        public ICollection<Tshirt> Tshirts { get; set; }
        public ICollection<Filament> Filaments { get; set; }
        public ICollection<Vinyl> Vinyls { get; set; }
    }
}
