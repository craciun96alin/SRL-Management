using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;
using System;

namespace FirmaAPP.BusinessLogic.Core
{
    public class BusinessDetailsBLL
    {
        public int GetBusinessDetailsIDByUserID(int currentUserId)
        {
            try
            {
                BusinessDetailsDAL bdDAL = new BusinessDetailsDAL();
                //verify path
                int appSettingsID = bdDAL.GetBusinessDetailsIDByUserID(currentUserId);
                return appSettingsID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddBusinessDetails(BusinessDetails businessDetails)
        {
            try
            {
                BusinessDetailsDAL bdDAL = new BusinessDetailsDAL();
                bdDAL.AddBusinessDetails(businessDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateBusinessDetails(BusinessDetails businessDetails)
        {
            try
            {
                BusinessDetailsDAL bdDAL = new BusinessDetailsDAL();
                bdDAL.UpdateBusinessDetails(businessDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BusinessDetails GetBusinessDetailsByUserID()
        {
            try
            {
                BusinessDetailsDAL bdDAL = new BusinessDetailsDAL();
                return bdDAL.GetBusinessDetailsByUserID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateMoney(Enums.MoneyFrom moneyFrom, float totalPrice, Enums.OrderType orderType)
        {
            try
            {
                BusinessDetailsDAL bdDAL = new BusinessDetailsDAL();
                BusinessDetails bd = new BusinessDetails();
                bd = bdDAL.GetBusinessDetailsByUserID();
                
                if(orderType == Enums.OrderType.Achiziție)
                { 
                    //TO DO verify if you have money and bill if is the case
                    if(moneyFrom == Enums.MoneyFrom.Extra)
                    {
                        bd.ExtraMoney -= totalPrice;
                    }
                    if(moneyFrom == Enums.MoneyFrom.Digital)
                    {
                        bd.DigitalMoney -= totalPrice;
                    }
                    if(moneyFrom == Enums.MoneyFrom.Cash)
                    {
                        bd.DigitalMoney -= totalPrice;
                    }
                }
                else
                {
                    if (moneyFrom == Enums.MoneyFrom.Extra)
                    {
                        bd.ExtraMoney += totalPrice;
                    }
                    if (moneyFrom == Enums.MoneyFrom.Digital)
                    {
                        bd.DigitalMoney += totalPrice;
                    }
                    if (moneyFrom == Enums.MoneyFrom.Cash)
                    {
                        bd.DigitalMoney += totalPrice;
                    }
                }
                bdDAL.UpdateBusinessDetails(bd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
