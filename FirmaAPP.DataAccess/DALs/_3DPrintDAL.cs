using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class _3DPrintDAL
    {
        DBContext context = new DBContext();

        public int Add3DPrint(_3DPrint _3DPrint)
        {
            context.Add<_3DPrint>(_3DPrint);
            context.SaveChanges();
            return _3DPrint._3DPrintID;
        }

        public void Update3DPrint(_3DPrint _3DPrint)
        {
            context.Update<_3DPrint>(_3DPrint);
            context.SaveChanges();
        }

        public List<_3DPrint> GetAll3DPrint()
        {
            var _3Dprints = context._3DPrints.ToList();
            return _3Dprints;
        }

        public _3DPrint Get3DPrintByName(string name)
        {
            var print = context._3DPrints.Where(n => n.Name == name).FirstOrDefault();
            return print;
        }

        public void Remove3DPrint(_3DPrint _3DPrint)
        {
            context.Remove<_3DPrint>(_3DPrint);
            context.SaveChanges();
        }

        public _3DPrint Get3DPrintByID(int _3DPrintID)
        {
            var print = context._3DPrints.Where(n => n._3DPrintID == _3DPrintID).FirstOrDefault();
            return print;
        }
    }
}
