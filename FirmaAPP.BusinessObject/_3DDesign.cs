using System;
using System.Collections.Generic;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class _3DDesign : IIdentifier
    {
        public int _3DDesignID { get; set; }

        public Enums.DesignStatus DesignStatus { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DeadLineDate { get; set; }
        public DateTime? FinalizeDate { get; set; }
        public string ProjectName { get; set; }

        public byte[] Project { get; set; }
        public int HoursOfWork { get; set; } // in min
        public Enums.Rating Rating { get; set; }
        public string Description { get; set; }

        public IList<_3DDesignOrder> _3DDesignOrders { get; set; }

        //Used for the extension method, is ignored from the DB
        public int Id { get { return _3DDesignID; }}
    }
}
