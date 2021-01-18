using System;
using System.Collections.Generic;
using System.Linq;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class TshirtsBLL
    {
        private bool VerifyInputData(Tshirt tshirt)
        {
            TshirtsDAL tDAL = new TshirtsDAL();
            if(tshirt.Provider == null)
                throw new Exception(AppTranslations.WarningInfoBox +  AppTranslations.VerifyProviderToBeCompleted );
            if (tshirt.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if(tshirt.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            Tshirt t = tDAL.GetTshirtByName(tshirt.Name);
            if (t != null && t.TshirtID != tshirt.TshirtID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddTshirt(Tshirt tshirt)
        {
            try
            {
                VerifyInputData(tshirt);

                TshirtsDAL tDAL = new TshirtsDAL();
                tDAL.AddTshirt(tshirt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Tshirt> GetAllTshirts()
        {
            try
            {
                TshirtsDAL tDAL = new TshirtsDAL();
                ProvidersDAL pDAL = new ProvidersDAL();
                AttributeColorDAL acDAL = new AttributeColorDAL();
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                var tshirts = tDAL.GetAllTshirts();
                foreach (Tshirt t in tshirts)
                {
                    if (t.Provider == null && t.ProviderID != null)
                    {
                        t.Provider = pDAL.GetProviderById(t.ProviderID);
                    }
                    if (t.Color == null && t.AttributeColorID != null)
                    {
                        t.Color = acDAL.GetAttributeColorByID(t.AttributeColorID);
                    }
                    if (t.Type == null && t.AttributeTshirtsTypeID != null)
                    {
                        t.Type = attDAL.GetAttributeTshirtsTypeByID(t.AttributeTshirtsTypeID);
                    }
                }
                return tshirts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTshirt(Tshirt tshirt)
        {
            try
            {
                VerifyInputData(tshirt);
                TshirtsDAL tDAL = new TshirtsDAL();
                tDAL.UpdateTshirt(tshirt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteTshirt(Tshirt tshirt)
        {
            TshirtsDAL tDAL = new TshirtsDAL();
            tDAL.RemoveTshirt(tshirt);
        }

        public List<string> GetTshirtsNameByProvider(Provider provider)
        {
            try
            {
                List<string> TshirtsName = new List<string>();
                TshirtsDAL tDAL = new TshirtsDAL();
                AttributeColorDAL acDAL = new AttributeColorDAL();
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                var Tshirts = tDAL.GetTshirtsByProviderId(provider.ProviderID);
                foreach (Tshirt t in Tshirts)
                {
                    if (t.Color == null && t.AttributeColorID != null)
                    {
                        t.Color = acDAL.GetAttributeColorByID(t.AttributeColorID);
                    }
                    if (t.Type == null && t.AttributeTshirtsTypeID != null)
                    {
                        t.Type = attDAL.GetAttributeTshirtsTypeByID(t.AttributeTshirtsTypeID);
                    }
                    var TshirtName =  t.TypeName + ", " + t.ColorName + ", " + t.Rating;
                    TshirtsName.Add(TshirtName);
                }
                return TshirtsName.Distinct().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStock(int tshirtID, int quantity)
        {
            try
            {
                //To DO verify
                Tshirt t = GetTshirtByID(tshirtID);
                t.Stock += quantity;
                UpdateTshirt(t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetTshirtIDByAttributes(List<string> tshirtAttributes, string providerName)
        {
            try
            {
                TshirtsDAL tDAL = new TshirtsDAL();
                ProvidersBLL pBLL = new ProvidersBLL();
                var provider = pBLL.GetProviderByName(providerName);
                int tshirtID = tDAL.GetTshirtIDByAttributes(tshirtAttributes, provider.ProviderID);
                return tshirtID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Tshirt GetTshirtByID(int tshirtID)
        {
            try
            {
                TshirtsDAL tDAL = new TshirtsDAL();
                ProvidersDAL pDAL = new ProvidersDAL();
                AttributeColorDAL acDAL = new AttributeColorDAL();
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                Tshirt t = tDAL.GetTshirtByID(tshirtID);
                if (t.Provider == null && t.ProviderID != null)
                {
                    t.Provider = pDAL.GetProviderById(t.ProviderID);
                }
                if (t.Color == null && t.AttributeColorID != null)
                {
                    t.Color = acDAL.GetAttributeColorByID(t.AttributeColorID);
                }
                if (t.Type == null && t.AttributeTshirtsTypeID != null)
                {
                    t.Type = attDAL.GetAttributeTshirtsTypeByID(t.AttributeTshirtsTypeID);
                }
                return t;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
