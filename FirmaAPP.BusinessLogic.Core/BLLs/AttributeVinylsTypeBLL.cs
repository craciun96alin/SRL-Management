using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class AttributeVinylsTypeBLL
    {
        private bool VerifyInputData(AttributeVinylsType attributeVinylsType)
        {
            AttributeVinylsTypeDAL avtDAL = new AttributeVinylsTypeDAL();

            if (attributeVinylsType.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            AttributeVinylsType avt = avtDAL.GetAttributeVinylsTypeByName(attributeVinylsType.Name);
            if (avt != null && avt.AttributeVinylsTypeID != attributeVinylsType.AttributeVinylsTypeID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddAttributeVinylsType(AttributeVinylsType attributeVinylsType)
        {
            try
            {
                VerifyInputData(attributeVinylsType);
                AttributeVinylsTypeDAL avtDAL = new AttributeVinylsTypeDAL();
                avtDAL.AddAttributeVinylsType(attributeVinylsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAttributeVinylsType(AttributeVinylsType attributeVinylsType)
        {
            try
            {
                VerifyInputData(attributeVinylsType);
                AttributeVinylsTypeDAL avtDAL = new AttributeVinylsTypeDAL();
                avtDAL.UpdateAttributeVinylsType(attributeVinylsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAttributeVinylsType(AttributeVinylsType attributeVinylsType)
        {
            try
            {
                AttributeVinylsTypeDAL avtDAL = new AttributeVinylsTypeDAL();
                avtDAL.RemoveAttributeVinylsType(attributeVinylsType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AttributeVinylsType> GetAllAttributeVinylsTypes()
        {
            try
            {
                AttributeVinylsTypeDAL avtDAL = new AttributeVinylsTypeDAL();
                var attributeVinylsTypes = avtDAL.GetAllAttributeVinylsType();
                return attributeVinylsTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllAttributeVinylsTypeNames()
        {
            try
            {
                AttributeVinylsTypeDAL aftDAL = new AttributeVinylsTypeDAL();
                var attributeTypesVinyl = aftDAL.GetAllAttributeVinylNames();
                return attributeTypesVinyl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AttributeVinylsType GetAttributeVinylsTypeByName(string name)
        {
            try
            {
                AttributeVinylsTypeDAL pDAL = new AttributeVinylsTypeDAL();
                var VinylsType = pDAL.GetAttributeVinylsTypeByName(name);
                return VinylsType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
