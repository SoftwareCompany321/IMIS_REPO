using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Banktransactions
    { 
        public decimal? Sn { get; set; }
        public decimal? Bankid { get; set; }
        public string Description { get; set; }
        public double? Dramount { get; set; }
        public double? Cramount { get; set; }
        public decimal? Incomeexptypeid { get; set; }
        public string Isoflastyear { get; set; }
        public string VchrDateNp { get; set; }
        public decimal? Orderinpaymentslip { get; set; }
        public decimal? VchrId { get; set; }
        public decimal? Billid { get; set; }
        public string Module { get; set; }
        public decimal? SubmoduleTypeId { get; set; }
        public decimal? DhrtiMasterId { get; set; }
        public decimal? ExpSlipId { get; set; }
        public string PaymentOrderNo { get; set; }
        public decimal? ChequeTypeId { get; set; }
        public string Payeename { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public string PayeenameEng { get; set; }

        public virtual AccDhrtiBillMaster DhrtiMaster { get; set; }
        public virtual AccSubModuleType SubmoduleType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
