using System.Collections.Generic;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class Provider
    {
        public int ProviderID { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }
        [LocalizedDisplayName("Country")]
        public string Country { get; set; }
        [LocalizedDisplayName("City")]
        public string City { get; set; }
        [LocalizedDisplayName("County")]
        public string County { get; set; }
        [LocalizedDisplayName("Adress")]
        public string Adress { get; set; }
        [LocalizedDisplayName("Phone")]
        public string Phone { get; set; }
        [LocalizedDisplayName("CUI")]
        public string CUI { get; set; }
        [LocalizedDisplayName("Rating")]
        public Enums.Rating Rating { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }
        [LocalizedDisplayName("IBAN")]
        public string IBAN { get; set; }
        [LocalizedDisplayName("TVAPaying")]
        public bool TVAPaying { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<Tshirt> Tshirts { get; set; }
        public ICollection<Filament> Filaments { get; set; }
        public ICollection<OtherPurchase> OtherPurchases { get; set; }
        public ICollection<Vinyl> Vinyls { get; set; }
    }
}
