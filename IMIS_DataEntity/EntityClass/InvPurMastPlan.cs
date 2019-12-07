using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurMastPlan
    {
        public decimal Id { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string PkgNo { get; set; }
        public double? ApproxAmt { get; set; }
        public double? Budget1year { get; set; }
        public double? Budget2year { get; set; }
        public double? Budget3year { get; set; }
        public string PurType { get; set; }
        public string AgreementType { get; set; }
        public string BudgetResource { get; set; }
        public string WorkStDate { get; set; }
        public string WorkEndDate { get; set; }
        public DateTime? WorkStDateAd { get; set; }
        public DateTime? WorkEndDateAd { get; set; }
        public string BudgetYear { get; set; }
        public string Remarks { get; set; }
    }
}
