using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class AttributeFilamentsTypeDAL
    {
        DBContext context = new DBContext();

        public void AddAttributeFilamentsType(AttributeFilamentsType filament)
        {
            context.Add<AttributeFilamentsType>(filament);
            context.SaveChanges();
        }

        public void UpdateAttributeFilamentsType(AttributeFilamentsType filament)
        {
            context.Update<AttributeFilamentsType>(filament);
            context.SaveChanges();
        }

        public void RemoveAttributeFilamentsType(AttributeFilamentsType filament)
        {
            context.Remove<AttributeFilamentsType>(filament);
            context.SaveChanges();
        }

        public AttributeFilamentsType GetAttributeFilamentsTypeByName(string name)
        {
            var filament = context.AttributeFilamentsType.Where(v => (v.Name == name)).FirstOrDefault();
            return filament;
        }

        public List<AttributeFilamentsType> GetAllAttributeFilamentsType()
        {
            var filaments = context.AttributeFilamentsType.ToList();
            return filaments;
        }

        public AttributeFilamentsType GetAttributeFilamentsTypeByID(int? AttributeFilamentsTypeID)
        {
            var filament = context.AttributeFilamentsType.Where(f => f.AttributeFilamentsTypeID == AttributeFilamentsTypeID).FirstOrDefault();
            return filament;
        }

        public List<string> GetAllAttributeFilamentNames()
        {
            var Names = context.AttributeFilamentsType.Select(p => p.Name).ToList();
            return Names;
        }
    }
}
