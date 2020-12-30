using System;
using System.Collections.Generic;
using System.IO;
using AppContext = FirmaAPP.Common.AppContext;
using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.Core
{
    public class _3DPrintsBLL
    {
        #region Verify data
        private bool VerifyInputData(_3DPrint _3DPrint)
        {
            _3DPrintDAL dDAL = new _3DPrintDAL();
            if (_3DPrint.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (_3DPrint.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);
            if(_3DPrint.FileName == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyFileToBeCompleted);

            _3DPrint dp = dDAL.Get3DPrintByName(_3DPrint.Name);
            if (dp != null && dp._3DPrintID != _3DPrint._3DPrintID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }
        #endregion

        public int Add3DPrint(_3DPrint _3DPrint)
        {
            try
            {
                VerifyInputData(_3DPrint);
                string fileName = CopyFileIn3DPrintFolder(_3DPrint);
                if (fileName != String.Empty)
                {
                    _3DPrint.FileName = fileName;
                }
                _3DPrintDAL pDAL = new _3DPrintDAL();
                _3DPrint._3DDesign = null;
                return pDAL.Add3DPrint(_3DPrint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update3DPrint(_3DPrint _3DPrint)
        {
            try
            {
                VerifyInputData(_3DPrint);
                _3DPrintDAL pDAL = new _3DPrintDAL();
                pDAL.Update3DPrint(_3DPrint);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<_3DPrint> GetAll3DPrints()
        {
            try
            {
                _3DPrintDAL pDAL = new _3DPrintDAL();
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                var _3DPrints = pDAL.GetAll3DPrint();
                foreach(_3DPrint dp in _3DPrints)
                {
                    if(dp._3DDesignID > 0)
                    {
                        dp._3DDesign = dDAL.Get3DDesignByID(dp._3DDesignID);
                    }
                }
                return _3DPrints;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete3DPrint(_3DPrint p)
        {
            try
            {
                _3DPrintDAL pDAL = new _3DPrintDAL();
                pDAL.Remove3DPrint(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public _3DPrint Get3DPrintByID(int _3DPrintID)
        {
            try
            {
                _3DPrintDAL pDAL = new _3DPrintDAL();
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                FilamentsDAL fDAL = new FilamentsDAL();
                var _3DPrint = pDAL.Get3DPrintByID(_3DPrintID);
                if (_3DPrint._3DDesignID > 0)
                {
                    _3DPrint._3DDesign = dDAL.Get3DDesignByID(_3DPrint._3DDesignID);
                }
                return _3DPrint;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<string> GetAll3DPrintsName()
        {
            try
            {
                List<string> _3DPrintsName = new List<string>();
                _3DPrintDAL pDAL = new _3DPrintDAL();
                var _3DPrints = pDAL.GetAll3DPrint();
                foreach (_3DPrint p in _3DPrints)
                {
                    var printName = p._3DPrintID + ", " + p.Name;
                    _3DPrintsName.Add(printName);
                }
                return _3DPrintsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region Private func
        private string CopyFileIn3DPrintFolder(_3DPrint _3DPrint)
        {
            string fileName = string.Empty;
            if (Directory.Exists(AppContext.Folder3DPrintPath) == true)
            {
                string path = AppContext.Folder3DPrintPath;
                if (Directory.Exists(path))
                {
                    path += "\\" + _3DPrint.CreationDate.Year.ToString();
                    if (Directory.Exists(path))
                    {
                        path += "\\" + _3DPrint.CreationDate.Month.ToString();
                        if (Directory.Exists(path))
                        {
                            path += "\\" + _3DPrint.CreationDate.Day.ToString();
                            if (Directory.Exists(path))
                            {
                                fileName = _3DPrint.Name + _3DPrint.FileName.Substring(_3DPrint.FileName.LastIndexOf('.'));
                                path += "\\" + fileName;
                                File.Copy(_3DPrint.FileName, path, false);
                                return fileName;
                            }
                            else
                            {
                                Directory.CreateDirectory(path);
                                fileName = CopyFileIn3DPrintFolder(_3DPrint);
                            }
                        }
                        else
                        {
                            Directory.CreateDirectory(path);
                            fileName = CopyFileIn3DPrintFolder(_3DPrint);
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        fileName = CopyFileIn3DPrintFolder(_3DPrint);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    fileName = CopyFileIn3DPrintFolder(_3DPrint);
                }
            }
            else
            {
                throw new Exception("Atenție: Înainte de a adăuga facturi trebuie să definești folder-ul destinat facturilor din setări!");
            }
            return fileName;
        }
        #endregion
    }
}
