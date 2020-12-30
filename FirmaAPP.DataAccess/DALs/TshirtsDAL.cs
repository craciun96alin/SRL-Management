using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public class TshirtsDAL
    {
        DBContext context = new DBContext();

        public void AddTshirt(Tshirt tshirt)
        {
            context.Add<Tshirt>(tshirt);
            context.SaveChanges();
        }

        public void UpdateTshirt(Tshirt tshirt)
        {
            context.Update<Tshirt>(tshirt);
            context.SaveChanges();
        }

        public void RemoveTshirt(Tshirt tshirt)
        {
            context.Remove<Tshirt>(tshirt);
            context.SaveChanges();
        }

        public List<Tshirt> GetAllTshirts()
        {
            var tshirts = context.Tshirts.ToList();
            return tshirts;
        }

        public Tshirt GetTshirtByName(string name)
        {
            var t = context.Tshirts.Where(n => n.Name == name).FirstOrDefault();
            {
                return t;
            }
        }

        public List<Tshirt> GetTshirtsByProviderId(int providerID)
        {
            var tshirts = context.Tshirts.Where(v => v.ProviderID == providerID).ToList();
            return tshirts;
        }

        public int GetTshirtIDByAttributes(List<string> tshirtAttributes, int providerID)
        {
            var tshirtID = context.Tshirts.Where(t => 
                                                      (t.Type == Enums.ParseEnum<Enums.TshirtType>(tshirtAttributes[0])) && 
                                                      (t.Color == Enums.ParseEnum<Enums.Color>(tshirtAttributes[1])) &&
                                                      (t.Rating == Enums.ParseEnum<Enums.Rating>(tshirtAttributes[2])) &&
                                                      (t.Sex == Enums.ParseEnum<Enums.Sex>(tshirtAttributes[3])) &&
                                                      (t.Size == Enums.ParseEnum<Enums.TshirtSize>(tshirtAttributes[4])) &&
                                                      (t.ProviderID == providerID)
                                                )
                                            .Select(t => t.TshirtID).FirstOrDefault();
            return tshirtID;
        }

        public Tshirt GetTshirtByID(int tshirtID)
        {
            var tshirt = context.Tshirts.Where(t => t.TshirtID == tshirtID).FirstOrDefault();
            return tshirt;
        }
    }
}
