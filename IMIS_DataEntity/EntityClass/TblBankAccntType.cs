using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblBankAccntType
    {
        public TblBankAccntType()
        {
            OrgBankAccount = new HashSet<OrgBankAccount>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<OrgBankAccount> OrgBankAccount { get; set; }
    }
}
