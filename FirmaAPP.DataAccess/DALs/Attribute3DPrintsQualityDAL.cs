using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class Attribute3DPrintsQualityDAL
    {
        DBContext context = new DBContext();

        public void AddAttribute3DPrintsQuality(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            context.Add<Attribute3DPrintsQuality>(attribute3DPrintsQuality);
            context.SaveChanges();
        }

        public void UpdateAttribute3DPrintsQuality(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            context.Update<Attribute3DPrintsQuality>(attribute3DPrintsQuality);
            context.SaveChanges();
        }

        public void RemoveAttribute3DPrintsQuality(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            context.Remove<Attribute3DPrintsQuality>(attribute3DPrintsQuality);
            context.SaveChanges();
        }

        public Attribute3DPrintsQuality GetAttribute3DPrintsQualityByName(string name)
        {
            var attribute3DPrintsQuality = context.Attribute3DPrintsQuality.Where(v => (v.Name == name)).FirstOrDefault();
            return attribute3DPrintsQuality;
        }

        public List<Attribute3DPrintsQuality> GetAllAttribute3DPrintsQuality()
        {
            var attribute3DPrintsQualitys = context.Attribute3DPrintsQuality.ToList();
            return attribute3DPrintsQualitys;
        }

        public Attribute3DPrintsQuality GetAttribute3DPrintsQualityByID(int? Attribute3DPrintsQualityID)
        {
            var attribute3DPrintsQuality = context.Attribute3DPrintsQuality.Where(f => f.Attribute3DPrintsQualityID == Attribute3DPrintsQualityID).FirstOrDefault();
            return attribute3DPrintsQuality;
        }

        public List<string> GetAllAttribute3DPrintsQualityNames()
        {
            var Names = context.Attribute3DPrintsQuality.Select(p => p.Name).ToList();
            return Names;
        }
    }
}
