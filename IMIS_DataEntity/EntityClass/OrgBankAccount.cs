using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class OrgBankAccount
    {
        public decimal Id { get; set; }
        public decimal? OrgId { get; set; }
        public decimal? Bankid { get; set; }
        public decimal? BranchId { get; set; }
        public decimal? BankAccntTypeId { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }

        public virtual TblBankAccntType BankAccntType { get; set; }
        public virtual BankBranch Branch { get; set; }
        public virtual AccOrgMaster Org { get; set; }
    }
}
