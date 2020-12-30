using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class Filament
    {
        public int FilamentID { get; set; }

        [DisplayName("Nume")]
        public string Name { get; set; }
        public int? ProviderID { get; set; }
        
        public Provider Provider { get; set; }
        [DisplayName("Furnizor")]
        public string ProviderName => Provider != null ? Provider.Name : string.Empty;
        [DisplayName("Tip")]
        public Enums.FilamentType Type { get; set; }
        [DisplayName("Culoare")]
        public Enums.Color Color { get; set; }
        [DisplayName("Stoc(grame)")]
        public float Stock { get; set; }
        public Enums.Rating Rating { get; set; }
        [DisplayName("Descriere")]
        public string Description { get; set; }

        public IList<FilamentOrder> _filamentOrders { get; set; }
    }
}
