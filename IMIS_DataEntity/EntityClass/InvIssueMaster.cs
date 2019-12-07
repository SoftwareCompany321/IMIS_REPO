using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIssueMaster
    {
        public decimal Id { get; set; }
        public string IssueNo { get; set; }
        public decimal? RequestId { get; set; }
        public decimal? IssueBy { get; set; }
        public decimal? IssueReceive { get; set; }
        public decimal? ReceiveEmpId { get; set; }
        public string IssueDt { get; set; }
        public string Remarks { get; set; }
        public string IssueByCat { get; set; }
        public string HoName { get; set; }
        public string HoPost { get; set; }
        public decimal? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public decimal? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public decimal? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public string BudgetYear { get; set; }
        public decimal? Type { get; set; }
        public string TransferDecisionNo { get; set; }
        public string TransferDecisionDate { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual PisEmployeeMaster CheckByNavigation { get; set; }
        public virtual PisEmployeeMaster IssueByNavigation { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvRequisitionMast Request { get; set; }
    }
}
