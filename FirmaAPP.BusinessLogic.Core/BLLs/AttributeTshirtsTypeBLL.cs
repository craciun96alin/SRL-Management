using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class AttributeTshirtsTypeBLL
    {
        private bool VerifyInputData(AttributeTshirtsType attributeTshirtsType)
        {
            AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();

            if (attributeTshirtsType.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            AttributeTshirtsType avt = attDAL.GetAttributeTshirtsTypeByName(attributeTshirtsType.Name);
            if (avt != null && avt.AttributeTshirtsTypeID != attributeTshirtsType.AttributeTshirtsTypeID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddAttributeTshirtsType(AttributeTshirtsType attributeTshirtsType)
        {
            try
            {
                VerifyInputData(attributeTshirtsType);
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                attDAL.AddAttributeTshirtsType(attributeTshirtsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAttributeTshirtsType(AttributeTshirtsType attributeTshirtsType)
        {
            try
            {
                VerifyInputData(attributeTshirtsType);
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                attDAL.UpdateAttributeTshirtsType(attributeTshirtsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAttributeTshirtsType(AttributeTshirtsType attributeTshirtsType)
        {
            try
            {
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                attDAL.RemoveAttributeTshirtsType(attributeTshirtsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AttributeTshirtsType> GetAllAttributeTshirtsTypes()
        {
            try
            {
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                var attributeTshirtsTypes = attDAL.GetAllAttributeTshirtsType();
                return attributeTshirtsTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllAttributeTshirtsTypeNames()
        {
            try
            {
                AttributeTshirtsTypeDAL attDAL = new AttributeTshirtsTypeDAL();
                var attributeTshirtsTypes = attDAL.GetAllAttributeTshirtsTypeNames();
                return attributeTshirtsTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AttributeTshirtsType GetAttributeTshirtsTypeByName(string name)
        {
            try
            {
                AttributeTshirtsTypeDAL pDAL = new AttributeTshirtsTypeDAL();
                var tshirtsType = pDAL.GetAttributeTshirtsTypeByName(name);
                return tshirtsType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
