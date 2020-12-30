using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class _3DDesignsDAL
    {
        DBContext context = new DBContext();

        public _3DDesign Get3DDesignByName(string printName)
        {
            var design = context._3DDesigns.Where(n => n.Name == printName).FirstOrDefault();
            return design;
        }

        public List<string> GetAll3DDesignsName()
        {
            var designsName = context._3DDesigns.Select(p => p.Name).ToList();
            return designsName;
        }

        public int Add3DDesign(_3DDesign _3DDesign)
        {
            context.Add<_3DDesign>(_3DDesign);
            context.SaveChanges();
            return _3DDesign._3DDesignID;
        }

        public void Update3DDesign(_3DDesign _3DDesign)
        {
            AppHelper.DetachLocal(context, _3DDesign, _3DDesign._3DDesignID);
            context.SaveChanges();
            // 
            //var local = context.Set<_3DDesign>()
            //    .Local
            //    .FirstOrDefault(entry => entry._3DDesignID.Equals(_3DDesign._3DDesignID));

            //// check if local is not null 
            //if (local != null)
            //{
            //    // detach
            //    context.Entry(local).State = EntityState.Detached;
            //}
            //// set Modified flag in your entry
            //context.Entry(_3DDesign).State = EntityState.Modified;

            //// save 
            //context.SaveChanges();

            //context._3DDesigns.Update(_3DDesign);
            //context.SaveChanges();
        }

        public void Remove3DDesign(_3DDesign _3DDesign)
        {
            context.Remove<_3DDesign>(_3DDesign);
            context.SaveChanges();
        }

        public List<_3DDesign> GetAll3DDesigns()
        {
            var _3Ddesigns = context._3DDesigns.ToList();
            return _3Ddesigns;
        }

        public _3DDesign Get3DDesignByID(int? _3DDesignID)
        {
            var design = context._3DDesigns.Where(n => n._3DDesignID == _3DDesignID).FirstOrDefault();
            return design;
        }
    }
}
