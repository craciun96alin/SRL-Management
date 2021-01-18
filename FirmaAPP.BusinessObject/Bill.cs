using FirmaAPP.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaAPP.BusinessObject
{
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }
        [LocalizedDisplayName("Name")]
        public string BillName { get; set; }
        [LocalizedDisplayName("Status")]
        public Enums.BillStatus BillStatus { get; set; }
        public byte[] File { get; set; }
        [LocalizedDisplayName("File")]
        public string FileName { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }
        [LocalizedDisplayName("Date")]
        public DateTime BillDate { get; set; }
        public Order _order { get; set; }
    }
}
