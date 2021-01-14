using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class AttributeColorBLL
    {
        private bool VerifyInputData(AttributeColor attributeColor)
        {
            AttributeColorDAL aftDAL = new AttributeColorDAL();

            if (attributeColor.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            AttributeColor avt = aftDAL.GetAttributeColorByName(attributeColor.Name);
            if (avt != null && avt.AttributeColorID != attributeColor.AttributeColorID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddAttributeColor(AttributeColor attributeColor)
        {
            try
            {
                VerifyInputData(attributeColor);
                AttributeColorDAL aftDAL = new AttributeColorDAL();
                aftDAL.AddAttributeColor(attributeColor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAttributeColor(AttributeColor attributeColor)
        {
            try
            {
                VerifyInputData(attributeColor);
                AttributeColorDAL aftDAL = new AttributeColorDAL();
                aftDAL.UpdateAttributeColor(attributeColor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteAttributeColor(AttributeColor attributeColor)
        {
            try
            {
                AttributeColorDAL aftDAL = new AttributeColorDAL();
                aftDAL.RemoveAttributeColor(attributeColor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AttributeColor GetAttributeColorByName(string name)
        {
            try
            {
                AttributeColorDAL pDAL = new AttributeColorDAL();
                var color = pDAL.GetAttributeColorByName(name);
                return color;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AttributeColor> GetAllAttributeColors()
        {
            try
            {
                AttributeColorDAL aftDAL = new AttributeColorDAL();
                var attributeColors = aftDAL.GetAllAttributeColors();
                return attributeColors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllAttributeColorNames()
        {
            try
            {
                AttributeColorDAL aftDAL = new AttributeColorDAL();
                var attributeColors = aftDAL.GetAllAttributeColorNames();
                return attributeColors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
