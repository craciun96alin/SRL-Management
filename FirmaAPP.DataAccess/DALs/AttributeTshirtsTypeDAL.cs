using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class AttributeTshirtsTypeDAL
    {
        DBContext context = new DBContext();

        public void AddAttributeTshirtsType(AttributeTshirtsType attributeTshirt)
        {
            context.Add<AttributeTshirtsType>(attributeTshirt);
            context.SaveChanges();
        }

        public void UpdateAttributeTshirtsType(AttributeTshirtsType attributeTshirt)
        {
            context.Update<AttributeTshirtsType>(attributeTshirt);
            context.SaveChanges();
        }

        public void RemoveAttributeTshirtsType(AttributeTshirtsType attributeTshirt)
        {
            context.Remove<AttributeTshirtsType>(attributeTshirt);
            context.SaveChanges();
        }

        public AttributeTshirtsType GetAttributeTshirtsTypeByName(string name)
        {
            var attributeTshirt = context.AttributeTshirtsType.Where(v => (v.Name == name)).FirstOrDefault();
            return attributeTshirt;
        }

        public List<AttributeTshirtsType> GetAllAttributeTshirtsType()
        {
            var attributeTshirts = context.AttributeTshirtsType.ToList();
            return attributeTshirts;
        }

        public AttributeTshirtsType GetAttributeTshirtsTypeByID(int? AttributeTshirtsTypeID)
        {
            var attributeTshirt = context.AttributeTshirtsType.Where(f => f.AttributeTshirtsTypeID == AttributeTshirtsTypeID).FirstOrDefault();
            return attributeTshirt;
        }

        public List<string> GetAllAttributeTshirtsTypeNames()
        {
            var Names = context.AttributeTshirtsType.Select(p => p.Name).ToList();
            return Names;
        }
    }
}
