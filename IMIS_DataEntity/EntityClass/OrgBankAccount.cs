using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class OrgBankAccount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? OrgId { get; set; }
        public int? Bankid { get; set; }
        public int? BranchId { get; set; }
        public int? BankAccntTypeId { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }

        public virtual TblBankAccntType BankAccntType { get; set; }
        public virtual BankBranch Branch { get; set; }
        public virtual AccOrgMaster Org { get; set; }
    }
}
