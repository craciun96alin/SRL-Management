using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class AttributeFilamentsTypeBLL
    {
        private bool VerifyInputData(AttributeFilamentsType attributeFilamentsType)
        {
            AttributeFilamentsTypeDAL aftDAL = new AttributeFilamentsTypeDAL();

            if (attributeFilamentsType.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            AttributeFilamentsType avt = aftDAL.GetAttributeFilamentsTypeByName(attributeFilamentsType.Name);
            if (avt != null && avt.AttributeFilamentsTypeID != attributeFilamentsType.AttributeFilamentsTypeID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddAttributeFilamentsType(AttributeFilamentsType attributeFilamentsType)
        {
            try
            {
                VerifyInputData(attributeFilamentsType);
                AttributeFilamentsTypeDAL aftDAL = new AttributeFilamentsTypeDAL();
                aftDAL.AddAttributeFilamentsType(attributeFilamentsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAttributeFilamentsType(AttributeFilamentsType attributeFilamentsType)
        {
            try
            {
                VerifyInputData(attributeFilamentsType);
                AttributeFilamentsTypeDAL aftDAL = new AttributeFilamentsTypeDAL();
                aftDAL.UpdateAttributeFilamentsType(attributeFilamentsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAttributeFilamentsType(AttributeFilamentsType attributeFilamentsType)
        {
            try
            {
                AttributeFilamentsTypeDAL aftDAL = new AttributeFilamentsTypeDAL();
                aftDAL.RemoveAttributeFilamentsType(attributeFilamentsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AttributeFilamentsType> GetAllAttributeFilamentsTypes()
        {
            try
            {
                AttributeFilamentsTypeDAL aftDAL = new AttributeFilamentsTypeDAL();
                var attributeFilamentsTypes = aftDAL.GetAllAttributeFilamentsType();
                return attributeFilamentsTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllAttributeFilamentsTypeNames()
        {
            try
            {
                AttributeFilamentsTypeDAL aftDAL = new AttributeFilamentsTypeDAL();
                var attributeTypesFilament = aftDAL.GetAllAttributeFilamentNames();
                return attributeTypesFilament;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AttributeFilamentsType GetAttributeFilamentsTypeByName(string name)
        {
            try
            {
                AttributeFilamentsTypeDAL pDAL = new AttributeFilamentsTypeDAL();
                var FilamentsType = pDAL.GetAttributeFilamentsTypeByName(name);
                return FilamentsType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
