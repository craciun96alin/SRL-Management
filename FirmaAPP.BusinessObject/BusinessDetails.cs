using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class BusinessDetails
    {
        public int BusinessDetailsID { get; set; }

        public string Name { get; set; }
        public string CUI { get; set; }
        public string IBAN { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string NrReg { get; set; }
        public bool TVAPaying { get; set; }
        public float DigitalMoney { get; set; }
        public float CashMoney { get; set; }
        public float ExtraMoney { get; set; }

        public int UserID { get; set; }
        public User _user { get; set; }
    }
}
