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
    public class _3DPrintListPresenter
    {
        private I3DPrintListView _view;
        public _3DPrintListPresenter(I3DPrintListView view)
        {
            this._view = view;
        }
        public void Init()
        {
            try
            {
                _3DPrintsBLL dBLL = new _3DPrintsBLL();
                _view._3DPrints = dBLL.GetAll3DPrints();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete3DPrints(List<_3DPrint> _3Dprints)
        {
            try
            {
                _3DPrintsBLL dBLL = new _3DPrintsBLL();
                string prints = "";
                foreach (_3DPrint p in _3Dprints)
                {
                    dBLL.Delete3DPrint(p);
                    prints += p.Name + ", ";
                }
                throw new Exception(AppTranslations.SuccesInfoBox + AppTranslations._3DPrint + " " + prints + " " + AppTranslations.RemoveWithSuccess);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Open3DPrint(_3DPrint _3DPrint)
        {
            try
            {
                var path = recreatePath(_3DPrint);
                if(path != string.Empty)
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
        private string recreatePath(_3DPrint _3DPrint)
        {
            string path = AppContext.Folder3DPrintPath;
            path += "\\" + _3DPrint.CreationDate.Year.ToString();
            path += "\\" + _3DPrint.CreationDate.Month.ToString();
            path += "\\" + _3DPrint.CreationDate.Day.ToString();
            var fileName = _3DPrint.Name + _3DPrint.FileName.Substring(_3DPrint.FileName.LastIndexOf('.'));
            path += "\\" + fileName;

            if (File.Exists(path))
                return path;
            else
                return string.Empty;
        }
        #endregion
    }
}
