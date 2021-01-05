using System;
using System.Collections.Generic;
using FirmaAPP.BusinessObject;
using FirmaAPP.Common;
using FirmaAPP.DataAccess;

namespace FirmaAPP.BusinessLogic.Core
{
    public class FilamentsBLL
    {
        private bool VerifyInputData(Filament filament)
        {
            FilamentsDAL fDAL = new FilamentsDAL();
            if (filament.Provider == null)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyProviderToBeCompleted);
            if (filament.Name == string.Empty)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyNameToBeCompleted);
            if (filament.Rating == Enums.Rating.Nedefinit)
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.VerifyRatingToBeCompleted);

            Filament f = fDAL.GetFilamentByName(filament.Name);
            if (f != null && f.FilamentID != filament.FilamentID)
            {
                throw new Exception(AppTranslations.WarningInfoBox + AppTranslations.NameAlreadyExist);
            }
            return true;
        }

        public void AddFilament(Filament filament)
        {
            try
            {
                VerifyInputData(filament);

                FilamentsDAL fDAL = new FilamentsDAL();
                fDAL.AddFilament(filament);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Filament> GetAllFilaments()
        {
            try
            {
                FilamentsDAL fDAL = new FilamentsDAL();
                ProvidersDAL pDAL = new ProvidersDAL();
                var filaments = fDAL.GetAllFilaments();
                foreach(Filament f in filaments)
                {
                    if(f.Provider == null && f.ProviderID!=null)
                    {
                        f.Provider = pDAL.GetProviderById(f.ProviderID);
                    }
                }
                return filaments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateFilament(Filament filament)
        {
            try
            {
                VerifyInputData(filament);
                FilamentsDAL fDAL = new FilamentsDAL();
                fDAL.UpdateFilament(filament);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFilament(Filament filament)
        {
            try
            {
                FilamentsDAL fDAL = new FilamentsDAL();
                fDAL.RemoveFilament(filament);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Filament GetFilamentByNameAndProvider(string filamentName, string providerName)
        {
            try
            {
                FilamentsDAL fDAL = new FilamentsDAL();
                ProvidersBLL pBLL = new ProvidersBLL();
                var provider = pBLL.GetProviderByName(providerName);
                var filament = fDAL.GetFilamentByNameAndProvider(filamentName, provider.ProviderID);
                return filament;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetFilamentsNameByProvider(Provider provider)
        {
            try
            {
                List<string> filamentsName = new List<string>();
                FilamentsDAL fDAL = new FilamentsDAL();
                var filaments = fDAL.GetFilamentsByProviderId(provider.ProviderID);
                foreach (Filament f in filaments)
                {
                    var filamentName = f.FilamentID+", "+f.Name + ", " + f.Type + ", " + f.Color + ", " + f.Rating;
                    filamentsName.Add(filamentName);
                }
                return filamentsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetFilamentsName()
        {
            try
            {
                List<string> filamentsName = new List<string>();
                FilamentsDAL fDAL = new FilamentsDAL();
                var filaments = fDAL.GetAllFilaments();
                foreach (Filament f in filaments)
                {
                    var filamentName = f.Name + ", " + f.Type + ", " + f.Color;
                    filamentsName.Add(filamentName);
                }
                return filamentsName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateStock(int filamentID, float quantity)
        {
            try
            {
                Filament f = GetFilamentByID(filamentID);
                f.Stock += quantity;
                UpdateFilament(f);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Filament GetFilamentByID(int? filamentID)
        {
            try
            {
                FilamentsDAL fDAL = new FilamentsDAL();
                return fDAL.GetFilamentByID(filamentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetFilamentIDByName(string filamentName)
        {
            try
            {
                FilamentsDAL fDAL = new FilamentsDAL();
                return fDAL.GetFilamentIDByName(filamentName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
