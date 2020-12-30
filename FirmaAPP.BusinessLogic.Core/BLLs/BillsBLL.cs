using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;
using System;
using System.IO;
using AppContext = FirmaAPP.Common.AppContext;

namespace FirmaAPP.BusinessLogic.Core
{
    public class BillsBLL
    {
        private string billType;
        private bool VerifyInputData(Bill vinyl)
        {

            return true;
        }
        public int AddAcquisitionBill(Bill bill)
        {
            try
            {
                billType = AppTranslations.BillAcquisitionType;
                VerifyInputData(bill);

                BillsDAL bDAL = new BillsDAL();

                string fileName = CopyFileInBillFolder(bill);
                if (fileName != String.Empty)
                {
                    bill.FileName = fileName;
                }
                var billID = bDAL.AddBill(bill);
                return billID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddSellingBill(Bill bill)
        {
            try
            {
                billType = AppTranslations.BillSellingType;
                VerifyInputData(bill);

                BillsDAL bDAL = new BillsDAL();

                string fileName = CopyFileInBillFolder(bill);
                if (fileName != String.Empty)
                {
                    bill.FileName = fileName;
                }
                var billID = bDAL.AddBill(bill);
                return billID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string CopyFileInBillFolder(Bill bill)
        {
            string fileName = string.Empty;
            if (Directory.Exists(AppContext.FolderBillPath) == true)
            {
                string path = AppContext.FolderBillPath + "\\" + billType;
                if (Directory.Exists(path))
                {
                    path += "\\" + bill.BillDate.Year.ToString();
                    if (Directory.Exists(path))
                    {
                        path += "\\" + bill.BillDate.Month.ToString();
                        if(Directory.Exists(path))
                        {
                            path += "\\" + bill.BillDate.Day.ToString();
                            if(Directory.Exists(path))
                            {
                                fileName = bill.BillName + bill.FileName.Substring(bill.FileName.LastIndexOf('.'));
                                path += "\\" + fileName;
                                File.Copy(bill.FileName, path,false);
                                return fileName;
                            }
                            else
                            {
                                Directory.CreateDirectory(path);
                                fileName = CopyFileInBillFolder(bill);
                            }
                        }
                        else
                        {
                            Directory.CreateDirectory(path);
                            fileName = CopyFileInBillFolder(bill);
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(path);
                        fileName = CopyFileInBillFolder(bill);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    fileName = CopyFileInBillFolder(bill);
                }
            }
            else
            {
                throw new Exception("Atenție: Înainte de a adăuga facturi trebuie să definești folder-ul destinat facturilor din setări!");
            }
            return fileName;
        }

        public void DeleteBill(Bill bill)
        {
            try
            {
                BillsDAL bDAL = new BillsDAL();
                bDAL.RemoveBill(bill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
