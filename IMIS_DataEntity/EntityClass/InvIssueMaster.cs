using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvIssueMaster
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string IssueNo { get; set; }
        public int? RequestId { get; set; }
        public int? IssueBy { get; set; }
        public int? IssueReceive { get; set; }
        public int? ReceiveEmpId { get; set; }
        public string IssueDt { get; set; }
        public string Remarks { get; set; }
        public string IssueByCat { get; set; }
        public string HoName { get; set; }
        public string HoPost { get; set; }
        public int? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public int? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public int? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public string BudgetYear { get; set; }
        public int? Type { get; set; }
        public string TransferDecisionNo { get; set; }
        public string TransferDecisionDate { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual PisEmployeeMaster CheckByNavigation { get; set; }
        public virtual PisEmployeeMaster IssueByNavigation { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvRequisitionMast Request { get; set; }
    }
}
