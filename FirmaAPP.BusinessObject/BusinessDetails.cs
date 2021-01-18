using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class BusinessDetails
    {
        public int BusinessDetailsID { get; set; }

        [LocalizedDisplayName("Name")]
        public string Name { get; set; }
        [LocalizedDisplayName("CUI")]
        public string CUI { get; set; }
        [LocalizedDisplayName("IBAN")]
        public string IBAN { get; set; }
        [LocalizedDisplayName("Country")]
        public string Country { get; set; }
        [LocalizedDisplayName("City")]
        public string City { get; set; }
        [LocalizedDisplayName("County")]
        public string County { get; set; }
        [LocalizedDisplayName("Address")]
        public string Address { get; set; }
        [LocalizedDisplayName("NrReg")]
        public string NrReg { get; set; }
        [LocalizedDisplayName("TVAPaying")]
        public bool TVAPaying { get; set; }
        [LocalizedDisplayName("DigitalMoney")]
        public float DigitalMoney { get; set; }
        [LocalizedDisplayName("CashMoney")]
        public float CashMoney { get; set; }
        [LocalizedDisplayName("ExtraMoney")]
        public float ExtraMoney { get; set; }

        public int UserID { get; set; }
        public User _user { get; set; }
    }
}
