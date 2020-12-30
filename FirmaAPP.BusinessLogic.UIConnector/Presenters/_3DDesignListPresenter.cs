using FirmaAPP.BusinessLogic.Core;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using AppContext = FirmaAPP.Common.AppContext;

namespace FirmaAPP.BusinessLogic.UIConnector
{
    public class _3DDesignListPresenter
    {
        private I3DDesignListView _view;
        public _3DDesignListPresenter(I3DDesignListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            try
            {
                _3DDesignsBLL dBLL = new _3DDesignsBLL();
                _view._3DDesigns = dBLL.GetAll3DDesigns();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete3DDesigns(List<_3DDesign> _3Ddesigns)
        {
            try
            {
                _3DDesignsBLL dBLL = new _3DDesignsBLL();
                string designs = "";
                foreach (_3DDesign d in _3Ddesigns)
                {
                    dBLL.Delete3DDesign(d);
                    designs += d.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations._3DDesign + " " + designs + " " + AppTranslations.RemoveWithSuccess);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Open3DDesign(_3DDesign _3DDesign)
        {
            try
            {
                var path = recreatePath(_3DDesign);
                if (path != string.Empty)
                {
                    Process.Start(path);
                }
                else
                {
                    throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.FileDoNotExist);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region private
        private string recreatePath(_3DDesign _3DDesign)
        {
            string path = AppContext.Folder3DDesignPath;
            path += "\\" + _3DDesign.CreationDate.Year.ToString();
            path += "\\" + _3DDesign.CreationDate.Month.ToString();
            path += "\\" + _3DDesign.CreationDate.Day.ToString();
            path += "\\" + _3DDesign.Name.ToString();
           // var fileName = _3DDesign.Name + _3DDesign.ProjectName.Substring(_3DDesign.ProjectName.LastIndexOf('.'));
           // path += "\\" + fileName;
            if (Directory.Exists(path))
                return path;
            else
                return string.Empty;
        }
        #endregion
    }
}
