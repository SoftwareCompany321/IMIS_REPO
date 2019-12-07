using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Contacts
    {
        public Contacts()
        {
            TblBgtMgmtSrcOrg = new HashSet<TblBgtMgmtSrcOrg>();
            TblBgtMgmtSrcRelease = new HashSet<TblBgtMgmtSrcRelease>();
        }

        public decimal Id { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Code { get; set; }
        public decimal? Districtid { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblBgtMgmtSrcOrg> TblBgtMgmtSrcOrg { get; set; }
        public virtual ICollection<TblBgtMgmtSrcRelease> TblBgtMgmtSrcRelease { get; set; }
    }
}
