using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class BusinessDetailsPresenter
    {
        #region Private members
        private IBusinessDetailsView _view;
        #endregion
        #region Constructor
        public BusinessDetailsPresenter(IBusinessDetailsView view)
        {
            this._view = view;
        }
        #endregion

        public int GetIDByUserID(int currentUserId)
        {
            BusinessDetailsBLL bdBLL = new BusinessDetailsBLL();
            int bdID = bdBLL.GetBusinessDetailsIDByUserID(currentUserId);
            return bdID;
        }

        public void AddUpdateBusinessDetails(BusinessDetails businessDetails)
        {
            try
            {
                BusinessDetailsBLL bdBLL = new BusinessDetailsBLL();

                if (businessDetails.BusinessDetailsID == 0)
                {
                    bdBLL.AddBusinessDetails(businessDetails);
                   // throw new Exception("Succes: Setările au fost adăugate!");
                }
                else
                {
                    bdBLL.UpdateBusinessDetails(businessDetails);
                   // throw new Exception("Succes: Setările au fost editate!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Init()
        {
            BusinessDetailsBLL bdBLL = new BusinessDetailsBLL();
            try
            {
                _view.BusinessDetails = bdBLL.GetBusinessDetailsByUserID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
