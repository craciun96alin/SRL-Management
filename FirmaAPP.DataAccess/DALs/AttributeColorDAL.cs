using FirmaAPP.BusinessObject;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class AttributeColorDAL
    {
        DBContext context = new DBContext();

        public void AddAttributeColor(AttributeColor color)
        {
            context.Add<AttributeColor>(color);
            context.SaveChanges();
        }

        public void UpdateAttributeColor(AttributeColor color)
        {
            context.Update<AttributeColor>(color);
            context.SaveChanges();
        }

        public void RemoveAttributeColor(AttributeColor color)
        {
            context.Remove<AttributeColor>(color);
            context.SaveChanges();
        }

        public AttributeColor GetAttributeColorByName(string name)
        {
            var color = context.AttributeColor.Where(v => (v.Name == name)).FirstOrDefault();
            return color;
        }

        public List<AttributeColor> GetAllAttributeColors()
        {
            var colors = context.AttributeColor.ToList();
            return colors;
        }

        public List<string> GetAllAttributeColorNames()
        {
            var ColorsName = context.AttributeColor.Select(p => p.Name).ToList();
            return ColorsName;
        }

        public AttributeColor GetAttributeColorByID(int? AttributeColorsID)
        {
            var color = context.AttributeColor.Where(f => f.AttributeColorID == AttributeColorsID).FirstOrDefault();
            return color;
        }
    }
}
