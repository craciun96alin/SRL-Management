using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class _3DPrint
    {
        public int _3DPrintID { get; set; }
        [DisplayName("Proiectare")]
        public string _3DDesignName => _3DDesign != null ? _3DDesign.Name : string.Empty;
        public int? _3DDesignID { get; set; }
        public _3DDesign _3DDesign { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; } // If dosen't work to create sa same path for both of us then upload file directly
        public byte[] FileGCode {get;set;} // If FilePath works then delete this
        public Enums.Rating Rating { get; set; }

        public IList<_3DPrintOrder> _3DPrintOrders { get; set; }
    }
}
