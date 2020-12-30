using System;
using System.Collections.Generic;
using System.Linq;
using FirmaAPP.BusinessObject;

namespace FirmaAPP.DataAccess
{
    public class FilamentsDAL
    {
        DBContext context = new DBContext();

        public void AddFilament(Filament filament)
        {
            context.Add<Filament>(filament);
            context.SaveChanges();
        }

        public void UpdateFilament(Filament filament)
        {
            context.Update<Filament>(filament);
            context.SaveChanges();
        }

        public void RemoveFilament(Filament filament)
        {
            context.Remove<Filament>(filament);
            context.SaveChanges();
        }

        public Filament GetFilamentByName(string name)
        {
            var filament = context.Filaments.Where(v => (v.Name == name)).FirstOrDefault();
            return filament;
        }

        public List<Filament> GetAllFilaments()
        {
            var filaments = context.Filaments.ToList();
            return filaments;
        }

        public Filament GetFilamentByNameAndProvider(string filamentName, int providerID)
        {
            var filament = context.Filaments.Where(v => (v.Name == filamentName) && (v.ProviderID == providerID)).FirstOrDefault();
            return filament;
        }

        public List<Filament> GetFilamentsByProviderId(int providerID)
        {
            var filaments = context.Filaments.Where(v => v.ProviderID == providerID).ToList();
            return filaments;
        }

        public Filament GetFilamentByID(int? filamentID)
        {
            var filament = context.Filaments.Where(f => f.FilamentID == filamentID).FirstOrDefault();
            return filament;
        }

        public int GetFilamentIDByName(string filamentName)
        {
            var filament = context.Filaments.Where(f => f.Name == filamentName).Select(f => f.FilamentID).FirstOrDefault();
            return filament;
        }
    }
}
