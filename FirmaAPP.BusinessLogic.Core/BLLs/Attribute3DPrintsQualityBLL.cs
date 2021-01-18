using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class Attribute3DPrintsQualityBLL
    {
        private bool VerifyInputData(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            Attribute3DPrintsQualityDAL a3DpqDAL = new Attribute3DPrintsQualityDAL();

            if (attribute3DPrintsQuality.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            Attribute3DPrintsQuality avt = a3DpqDAL.GetAttribute3DPrintsQualityByName(attribute3DPrintsQuality.Name);
            if (avt != null && avt.Attribute3DPrintsQualityID != attribute3DPrintsQuality.Attribute3DPrintsQualityID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddAttribute3DPrintsQuality(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            try
            {
                VerifyInputData(attribute3DPrintsQuality);
                Attribute3DPrintsQualityDAL a3DpqDAL = new Attribute3DPrintsQualityDAL();
                a3DpqDAL.AddAttribute3DPrintsQuality(attribute3DPrintsQuality);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAttribute3DPrintsQuality(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            try
            {
                VerifyInputData(attribute3DPrintsQuality);
                Attribute3DPrintsQualityDAL a3DpqDAL = new Attribute3DPrintsQualityDAL();
                a3DpqDAL.UpdateAttribute3DPrintsQuality(attribute3DPrintsQuality);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAttribute3DPrintsQuality(Attribute3DPrintsQuality attribute3DPrintsQuality)
        {
            try
            {
                Attribute3DPrintsQualityDAL a3DpqDAL = new Attribute3DPrintsQualityDAL();
                a3DpqDAL.RemoveAttribute3DPrintsQuality(attribute3DPrintsQuality);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Attribute3DPrintsQuality> GetAllAttribute3DPrintsQualitys()
        {
            try
            {
                Attribute3DPrintsQualityDAL a3DpqDAL = new Attribute3DPrintsQualityDAL();
                var attribute3DPrintsQualitys = a3DpqDAL.GetAllAttribute3DPrintsQuality();
                return attribute3DPrintsQualitys;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllAttribute3DPrintsQualitysNames()
        {
            try
            {
                Attribute3DPrintsQualityDAL a3DpqDAL = new Attribute3DPrintsQualityDAL();
                var attribute3DPrintsQualitys = a3DpqDAL.GetAllAttribute3DPrintsQualityNames();
                return attribute3DPrintsQualitys;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Attribute3DPrintsQuality GetAttribute3DPrintsQualityByName(string name)
        {
            try
            {
                Attribute3DPrintsQualityDAL pqDAL = new Attribute3DPrintsQualityDAL();
                var printsQuality = pqDAL.GetAttribute3DPrintsQualityByName(name);
                return printsQuality;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
