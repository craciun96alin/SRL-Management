using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class Order
    {
        public int OrderID { get; set; }
        [DisplayName("Descriere")]
        public string Description { get; set; }
        public Enums.OrderType OrderType { get; set; } // Based on this you'll know if the order is for selling or buying
        public int? CustomerID { get; set; }
        public int? ProviderID { get; set; }
        public int? BillID { get; set; }
        public DateTime  CreationDate { get; set; }
        public DateTime? DeadLineDate { get; set; }
        public DateTime? FinalizeDate { get; set; }
        [DisplayName("Status comandă")]
        public Enums.OrderStatus OrderStatus { get; set; }
        public int UserID { get; set; }
        [DisplayName("Preț transport")]
        public float ShippingPrice { get; set; }
        [DisplayName("Preț total")]
        public float TotalPrice { get; set; }

        // TO create one-to-many
        public Customer Customer { get; set; }
        public Provider Provider { get; set; }
        public Bill Bill { get; set; } // 1-1
        public User User { get; set; }

        public string CustomerName => Customer != null ? Customer.FirstName +" "+ Customer.LastName: string.Empty;
        [DisplayName("Furnizor")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [DisplayName("Factură")]
        public string BillName => Bill != null ? Bill.BillName : string.Empty;
        [DisplayName("Status factură")]
        public Enums.BillStatus BillStatus => Bill != null ? Bill.BillStatus : Enums.BillStatus.Void;
        [DisplayName("Utilizator")]
        public string UserName => User != null ? User.FirstName +" "+ User.LastName : string.Empty;



        // TO create many-to-many with selling products
        public IList<TshirtOrder> _tshirtOrders { get; set; }
        public IList<_3DPrintOrder> _3DPrintOrders { get; set; }
        public IList<_3DDesignOrder> _3DDesignOrders { get; set; }

        // TO create many-to-many with buying products
        public IList<FilamentOrder> _filamentOrders { get; set; }
        public IList<VinylOrder> _vinylOrders { get; set; }
        public IList<OtherPurchaseOrder> _otherPurchaseOrders { get; set; }
    }
}
