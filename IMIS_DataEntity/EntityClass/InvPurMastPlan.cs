using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurMastPlan
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string PkgNo { get; set; }
        public float? ApproxAmt { get; set; }
        public float? Budget1year { get; set; }
        public float? Budget2year { get; set; }
        public float? Budget3year { get; set; }
        public string PurType { get; set; }
        public string AgreementType { get; set; }
        public string BudgetResource { get; set; }
        public string WorkStDate { get; set; }
        public string WorkEndDate { get; set; }
        public DateTime? WorkStDateAd { get; set; }
        public DateTime? WorkEndDateAd { get; set; }
        public string BudgetYear { get; set; }
        public string Remarks { get; set; }
        public bool IsActive { get; set; }
    }
}
