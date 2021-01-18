using System;
using System.Collections.Generic;
using FirmaAPP.Common;

namespace FirmaAPP.BusinessObject
{
    public class _3DDesign : IIdentifier
    {
        public int _3DDesignID { get; set; }
        [LocalizedDisplayName("Status")]
        public Enums.DesignStatus DesignStatus { get; set; }
        [LocalizedDisplayName("Name")]
        public string Name { get; set; }
        [LocalizedDisplayName("CreationDate")]
        public DateTime CreationDate { get; set; }
        [LocalizedDisplayName("DeadLineDate")]
        public DateTime DeadLineDate { get; set; }
        [LocalizedDisplayName("FinalizeDate")]
        public DateTime? FinalizeDate { get; set; }
        [LocalizedDisplayName("Project")]
        public string ProjectName { get; set; }

        public byte[] Project { get; set; }
        [LocalizedDisplayName("HoursOfWork")]
        public int HoursOfWork { get; set; } // in min
        [LocalizedDisplayName("Rating")]
        public Enums.Rating Rating { get; set; }
        [LocalizedDisplayName("Description")]
        public string Description { get; set; }

        public IList<_3DDesignOrder> _3DDesignOrders { get; set; }

        //Used for the extension method, is ignored from the DB
        public int Id { get { return _3DDesignID; }}
    }
}
