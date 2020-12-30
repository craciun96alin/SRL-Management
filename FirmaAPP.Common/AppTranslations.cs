using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.Common
{
    public static class AppTranslations
    {
        public static string BillAcquisitionType = "Achiziții";
        public static string BillSellingType = "Vânzări";

        public static string Warning = "Atenție";
        public static string WarningInfoBox = "Atenție: ";
        public static string Succes = "Succes";
        public static string SuccesInfoBox = "Succes: ";
        public static string Error = "Eroare";
        public static string ErrorInfoBox = "Eroare: ";

        public static string WarningMessageBoxTitle = "Atenție!";
        public static string MessageBoxInfoConfirmation = "Ești sigur de datele introduse?";

        public static string SelectAtMostOneRow = "Selectează maxim un rând!";
        public static string SelectAtLeastOneRow = "Selectează cel puțin un rând!";
        public static string DeleteQuestion = "Doriți să ștergeți ";
        public static string AddWithSuccess = "a fost adăugat/ă!";
        public static string EditWithSuccess = "a fost editat/ă!";
        public static string RemoveWithSuccess = "a fost șters!";

        public  const string Customer = "Clientul";
        public static string Filament = "Filamentul";
        public static string AcquisitionOrder = "Comanda de achiziție";
        public static string Vinyl = "Vinyl-ul";
        public static string _3DDesign = "Proiectarea";
        public static string _3DPrint = "Piesa 3D";
        public static string Tshirt = "Tricoul";
        public static string Bill = "Factura";
        public static string Provider = "Furnizorul";
        public static string OtherPurchase = "Consumabilul";

        public static string FileDoNotExist = "Fișierul nu este disponibil! Verificați adresa fișierului din setări!";
        
        public static int BillForNoBillIndex = 2;

        public static string RON = " RON";
        public static string CancelConfirmation = "Toate datele noi introduse se vor pierde. Doriți să continuați?";

        public static string QPayWithExtraMoney = "Doriți să folosiți capitalul din banii extra?";
        public static string QPayWithCreditCart = "Doriți să folosiți capitalul de pe cardul firmei?";
        public static string QPayWithCash = "Doriți să folosiți capitalul din casa firmei?";

        public static string MoneyWasUpdated = "Capitalul firmei a fost actualizat! Verificați în detaliile firmei.";

        public static string VerifyNameToBeCompleted = " Trebuie completat campul \"Nume\"!";
        public static string NameAlreadyExist = " Numele este deja existent, vă rugăm alegeți un nume unic!";
        public static string VerifyRatingToBeCompleted = " Trebuie să selectați rating-ul!";
        public static string VerifyFileToBeCompleted = " Trebuie să selectați un fișier!";
    }
}
