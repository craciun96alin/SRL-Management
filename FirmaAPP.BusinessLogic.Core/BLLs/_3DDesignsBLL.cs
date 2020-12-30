using FirmaAPP.BusinessObject;
using FirmaAPP.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using AppContext = FirmaAPP.Common.AppContext;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessLogic.Core
{
    public class _3DDesignsBLL
    {

        #region Verify data
        private bool VerifyInputData(_3DDesign _3DDesign)
        {
            _3DDesignsDAL dDAL = new _3DDesignsDAL();
            if (_3DDesign.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (_3DDesign.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            _3DDesign dd = dDAL.Get3DDesignByName(_3DDesign.Name);
            if (dd != null && dd._3DDesignID != _3DDesign._3DDesignID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }
        #endregion

        public _3DDesign Get3DPrintByName(string printName)
        {
            try
            {
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                var _3DDesign = dDAL.Get3DDesignByName(printName);
                return _3DDesign;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<_3DDesign> GetAll3DDesigns()
        {
            try
            {
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                return dDAL.GetAll3DDesigns();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete3DDesign(_3DDesign _3DDesign)
        {
            try
            {
                VerifyInputData(_3DDesign);
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                dDAL.Remove3DDesign(_3DDesign);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAll3DDesignsName()
        {
            try
            {
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                var designsName = dDAL.GetAll3DDesignsName();
                return designsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add3DDesign(_3DDesign _3DDesign)
        {
            try
            {
                VerifyInputData(_3DDesign);
                string fileName = CopyFileIn3DDesignFolder(_3DDesign);
                if (fileName != String.Empty)
                {
                    _3DDesign.ProjectName = fileName;
                }
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                dDAL.Add3DDesign(_3DDesign);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update3DDesign(_3DDesign _3DDesign)
        {
            try
            {
                VerifyInputData(_3DDesign);
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                var initialDesign = dDAL.Get3DDesignByID(_3DDesign._3DDesignID);
                if (!_3DDesign.Project.SequenceEqual(initialDesign.Project))
                {
                    string fileName = CopyFileIn3DDesignFolder(_3DDesign);
                    if (fileName != String.Empty)
                    {
                        _3DDesign.ProjectName = fileName;
                    }
                }
                else
                {
                    _3DDesign.ProjectName = recreatePath(initialDesign);
                    string fileName = CopyFileIn3DDesignFolder(_3DDesign);
                    if (fileName != String.Empty)
                    {
                        _3DDesign.ProjectName = fileName;
                    }
                }
                dDAL.Update3DDesign(_3DDesign);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Private func
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
                return path +"\\"+ _3DDesign.ProjectName; 
            else
                return string.Empty;
        }

        private string CopyFileIn3DDesignFolder(_3DDesign _3DDesign)
        {
            string fileName = string.Empty;
            if (Directory.Exists(AppContext.Folder3DDesignPath) == true)
            {
                string path = AppContext.Folder3DDesignPath;
                if (Directory.Exists(path))
                {
                    path += "\\" + _3DDesign.CreationDate.Year.ToString();
                    if (Directory.Exists(path))
                    {
                        path += "\\" + _3DDesign.CreationDate.Month.ToString();
                        if (Directory.Exists(path))
                        {
                            path += "\\" + _3DDesign.CreationDate.Day.ToString();
                            if (Directory.Exists(path))
                            {
                                if (_3DDesign.ProjectName != string.Empty)
                                {
                                    fileName = _3DDesign.Name + _3DDesign.ProjectName.Substring(_3DDesign.ProjectName.LastIndexOf('.'));
                                    path += "\\" + _3DDesign.Name.ToString();
                                    if (Directory.Exists(path))
                                    {
                                        path += "\\"  + fileName;
                                        string initialFileName = _3DDesign.ProjectName.Substring(_3DDesign.ProjectName.LastIndexOf('\\') + 1);
                                        if (!File.Exists(path) || initialFileName != fileName)
                                            File.WriteAllBytes(path, _3DDesign.Project);
                                        return fileName;
                                    }
                                    else
                                    {
                                        Directory.CreateDirectory(path);
                                        fileName=CopyFileIn3DDesignFolder(_3DDesign);
                                    }
                                }
                                else
                                {
                                    return string.Empty;
                                }
                            }
                            else
                            {
                                Directory.CreateDirectory(path);
                                fileName=CopyFileIn3DDesignFolder(_3DDesign);
                            }
                        }
                        else
                        {
                            Directory.CreateDirectory(path);
                            fileName=CopyFileIn3DDesignFolder(_3DDesign);
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        fileName=CopyFileIn3DDesignFolder(_3DDesign);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    fileName=CopyFileIn3DDesignFolder(_3DDesign);
                }
            }
            else
            {
                throw new Exception("Atenție: Înainte de a adăuga facturi trebuie să definești folder-ul destinat facturilor din setări!");
            }
            return fileName;
        }

        public _3DDesign Get3DDesignByID(int _3DDesignID)
        {
            try
            {
                _3DDesignsDAL dDAL = new _3DDesignsDAL();
                return dDAL.Get3DDesignByID(_3DDesignID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
