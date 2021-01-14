using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class AttributeVinylsTypeDAL
    {
        DBContext context = new DBContext();

        public void AddAttributeVinylsType(AttributeVinylsType attributeVinyl)
        {
            context.Add<AttributeVinylsType>(attributeVinyl);
            context.SaveChanges();
        }

        public void UpdateAttributeVinylsType(AttributeVinylsType attributeVinyl)
        {
            context.Update<AttributeVinylsType>(attributeVinyl);
            context.SaveChanges();
        }

        public void RemoveAttributeVinylsType(AttributeVinylsType attributeVinyl)
        {
            context.Remove<AttributeVinylsType>(attributeVinyl);
            context.SaveChanges();
        }

        public AttributeVinylsType GetAttributeVinylsTypeByName(string name)
        {
            var attributeVinyl = context.AttributeVinylsType.Where(v => (v.Name == name)).FirstOrDefault();
            return attributeVinyl;
        }

        public List<AttributeVinylsType> GetAllAttributeVinylsType()
        {
            var attributeVinyls = context.AttributeVinylsType.ToList();
            return attributeVinyls;
        }

        public AttributeVinylsType GetAttributeVinylsTypeByID(int? AttributeVinylsTypeID)
        {
            var attributeVinyl = context.AttributeVinylsType.Where(f => f.AttributeVinylsTypeID == AttributeVinylsTypeID).FirstOrDefault();
            return attributeVinyl;
        }

        public List<string> GetAllAttributeVinylNames()
        {
            var Names = context.AttributeVinylsType.Select(p => p.Name).ToList();
            return Names;
        }
    }
}
