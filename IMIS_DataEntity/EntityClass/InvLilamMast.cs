using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamMast
    {
        public int Id { get; set; }
        public string LilamNo { get; set; }
        public int? IssueBy { get; set; }
        public int? Lilamtype { get; set; }
        public int? ReceiveBy { get; set; }
        public string ReceivePersonName { get; set; }
        public string RecivePersonPost { get; set; }
        public string Remarks { get; set; }
        public int? PrepBy { get; set; }
        public int? CheckBy { get; set; }
        public string IssueDt { get; set; }
        public int? AcceptBy { get; set; }
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
        public float? PernewsRate { get; set; }
        public float? AcceptPercent { get; set; }
        public int? Bankid { get; set; }
        public int? ValidDays { get; set; }
        public string FiscalyearChukta { get; set; }
    }
}
