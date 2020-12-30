using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class VinylDAL
    {
        DBContext context = new DBContext();

        public void AddVinyl(Vinyl vinyl)
        {
            context.Add<Vinyl>(vinyl);
            context.SaveChanges();
        }

        public void UpdateVinyl(Vinyl vinyl)
        {
            context.Update<Vinyl>(vinyl);
            context.SaveChanges();
        }

        public void RemoveVinyl(Vinyl vinyl)
        {
            context.Remove<Vinyl>(vinyl);
            context.SaveChanges();
        }

        public List<Vinyl> GetAllVinyls()
        {
            var vinyl = context.Vinyls.ToList();
            return vinyl;
        }

        public Vinyl GetVinylByName(string name)
        {
            var vinyl = context.Vinyls.Where(v => (v.Name == name)).FirstOrDefault();
            return vinyl;
        }

        public List<Vinyl> GetVinylsByProviderId(int providerID)
        {
            var vinyls = context.Vinyls.Where(v => v.ProviderID == providerID).ToList();
            return vinyls;
        }

        public Vinyl GetVinylByNameAndProvider(string vinylName, int providerID)
        {
            var vinyl = context.Vinyls.Where(v => (v.Name == vinylName) && (v.ProviderID == providerID)).FirstOrDefault();
            return vinyl;
        }

        public Vinyl GetVinylByID(int vinylID)
        {
            var vinyl = context.Vinyls.Where(v => v.VinylID == vinylID).FirstOrDefault();
            return vinyl;
        }
    }
}
