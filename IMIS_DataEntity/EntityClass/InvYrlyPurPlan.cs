using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvYrlyPurPlan
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public float? ApproxAmt { get; set; }
        public string PurType { get; set; }
        public string AgreementType { get; set; }
        public string AprxAmtAcptDate { get; set; }
        public string InfoPublishDate { get; set; }
        public string TendrSaleDate { get; set; }
        public string FormEntryDate { get; set; }
        public string TendrOpenDate { get; set; }
        public string TendrAcceptDate { get; set; }
        public string WrkOrderDate { get; set; }
        public string WrkAcmplshDate { get; set; }
        public DateTime? AnlysisDsgnDtAd { get; set; }
        public DateTime? AprxAmtAcptDtAd { get; set; }
        public DateTime? TendrAcceptDtAd { get; set; }
        public DateTime? TendrCallDtAd { get; set; }
        public DateTime? TendrOpenDtAd { get; set; }
        public DateTime? AgreementDtAd { get; set; }
        public DateTime? Wrk2FinDtAd { get; set; }
        public DateTime? WrkAcmplshDtAd { get; set; }
        public string Remarks { get; set; }
    }
}
