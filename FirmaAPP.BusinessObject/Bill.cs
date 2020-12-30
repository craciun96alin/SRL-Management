using FirmaAPP.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaAPP.BusinessObject
{
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillID { get; set; }
        public string BillName { get; set; }
        public Enums.BillStatus BillStatus { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public DateTime BillDate { get; set; }
        public Order _order { get; set; }
    }
}
