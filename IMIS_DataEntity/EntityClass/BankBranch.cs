using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class BankBranch
    {
        public BankBranch()
        {
            OrgBankAccount = new HashSet<OrgBankAccount>();
        }

        public int BranchId { get; set; }
        public int? Bankid { get; set; }
        public string Nepname { get; set; }
        public string Engname { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IsPermitted { get; set; }

        public virtual Bankmaster Bank { get; set; }
        public virtual ICollection<OrgBankAccount> OrgBankAccount { get; set; }
    }
}
