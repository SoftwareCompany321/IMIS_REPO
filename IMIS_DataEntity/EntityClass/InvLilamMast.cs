using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamMast
    {
        public decimal Id { get; set; }
        public string LilamNo { get; set; }
        public decimal? IssueBy { get; set; }
        public decimal? Lilamtype { get; set; }
        public decimal? ReceiveBy { get; set; }
        public string ReceivePersonName { get; set; }
        public string RecivePersonPost { get; set; }
        public string Remarks { get; set; }
        public decimal? PrepBy { get; set; }
        public decimal? CheckBy { get; set; }
        public string IssueDt { get; set; }
        public decimal? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public string PrepDt { get; set; }
        public string CheckDt { get; set; }
        public DateTime? IssueDtEng { get; set; }
        public DateTime? PrepDtEng { get; set; }
        public DateTime? CheckDtEng { get; set; }
        public string FiscalYear { get; set; }
        public DateTime? AcceptDtEng { get; set; }
        public string Pageno { get; set; }
        public string Registerno { get; set; }
        public string PublishDate { get; set; }
        public string Description { get; set; }
        public string NewspaperName { get; set; }
        public double? PernewsRate { get; set; }
        public double? AcceptPercent { get; set; }
        public decimal? Bankid { get; set; }
        public decimal? ValidDays { get; set; }
        public string FiscalyearChukta { get; set; }
    }
}
