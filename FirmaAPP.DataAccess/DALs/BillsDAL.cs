using System;
using System.Linq;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class BillsDAL
    {
        DBContext context = new DBContext();
        public int AddBill(Bill bill)
        {
            context.Add<Bill>(bill);
            context.SaveChanges();
            return bill.BillID;
        }

        public void RemoveBill(Bill bill)
        {
            context.Remove<Bill>(bill);
            context.SaveChanges();
        }

        public Bill GetBillById(int? billID)
        {
            var bill = context.Bills.Where(n => n.BillID == billID).FirstOrDefault();
            return bill;
        }
    }
}
