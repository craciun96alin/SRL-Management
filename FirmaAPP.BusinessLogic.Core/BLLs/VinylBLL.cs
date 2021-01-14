using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;

namespace FirmaAPP.BusinessLogic.Core
{
    public class VinylBLL
    {
        private bool VerifyInputData(Vinyl vinyl)
        {
            VinylDAL vDAL = new VinylDAL();
            if (vinyl.Provider == null)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyProviderToBeCompleted);
            if (vinyl.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (vinyl.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            Vinyl v = vDAL.GetVinylByName(vinyl.Name);
            if (v != null && v.VinylID != vinyl.VinylID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddVinyl(Vinyl vinyl)
        {
            try
            {
                VerifyInputData(vinyl);
                VinylDAL vDAL = new VinylDAL();
                vDAL.AddVinyl(vinyl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Vinyl> GetAllVinyls()
        {
            try
            {
                VinylDAL vDAL = new VinylDAL();
                ProvidersDAL pDAL = new ProvidersDAL();
                AttributeColorDAL acDAL = new AttributeColorDAL();
                AttributeVinylsTypeDAL avtDAL = new AttributeVinylsTypeDAL();
                var vinyls = vDAL.GetAllVinyls();
                foreach (Vinyl v in vinyls)
                {
                    if (v.Provider == null && v.ProviderID != null)
                    {
                        v.Provider = pDAL.GetProviderById(v.ProviderID);
                    }

                    if (v.Color == null && v.AttributeColorID != null)
                    {
                        v.Color = acDAL.GetAttributeColorByID(v.AttributeColorID);
                    }

                    if (v.Type == null && v.AttributeVinylsTypeID != null)
                    {
                        v.Type = avtDAL.GetAttributeVinylsTypeByID(v.AttributeVinylsTypeID);
                    }
                }
                return vinyls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateVinyl(Vinyl vinyl)
        {
            try
            {
                VerifyInputData(vinyl);
                VinylDAL vDAL = new VinylDAL();
                vDAL.UpdateVinyl(vinyl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteVinyl(Vinyl vinyl)
        {
            try
            {
                VinylDAL vDAL = new VinylDAL();
                vDAL.RemoveVinyl(vinyl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetVinylsNameByProvider(Provider provider)
        {
            try
            {
                List<string> vinylsName = new List<string>();
                VinylDAL vDAL = new VinylDAL();
                var vinyls = vDAL.GetVinylsByProviderId(provider.ProviderID);
                foreach(Vinyl v in vinyls)
                {
                    var vinylName = v.VinylID + ", "+ v.Name + ", " + v.Type + ", " + v.Color.Name + ", " + v.Rating;
                    vinylsName.Add(vinylName);
                }
                return vinylsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStock(int vinylID, float quantity)
        {
            try
            {
                // TO DO verify
                Vinyl v = GetVinylByID(vinylID);
                v.Stock += quantity;
                UpdateVinyl(v);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Vinyl GetVinylByNameAndProvider(string vinylName, string providerName)
        {
            try
            {
                VinylDAL vDAL = new VinylDAL();
                ProvidersBLL pBLL = new ProvidersBLL();
                var provider = pBLL.GetProviderByName(providerName);
                var vinyl = vDAL.GetVinylByNameAndProvider(vinylName,provider.ProviderID);
                return vinyl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Vinyl GetVinylByID(int vinylID)
        {
            try
            {
                VinylDAL vDAL = new VinylDAL();
                return vDAL.GetVinylByID(vinylID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
