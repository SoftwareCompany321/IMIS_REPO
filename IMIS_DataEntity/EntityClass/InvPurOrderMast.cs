using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvPurOrderMast
    {
        public InvPurOrderMast()
        {
            InvPurOrderDetl = new HashSet<InvPurOrderDetl>();
        }

        public int Id { get; set; }
        public string PurOrderNo { get; set; }
        public string RepairOrderNo { get; set; }
        public string LetterOrderNo { get; set; }
        public string CustomOrderNo { get; set; }
        public int? PurType { get; set; }
        public int? PurOrderType { get; set; }
        public int? SuppId { get; set; }
        public int? ReqId { get; set; }
        public string BudgetYear { get; set; }
        public string ReturnItemDt { get; set; }
        public DateTime? ReturnItemDtEng { get; set; }
        public int? PreparedBy { get; set; }
        public string PreparedDt { get; set; }
        public DateTime? PreparedDtEng { get; set; }
        public int? CheckedBy { get; set; }
        public string CheckedDt { get; set; }
        public DateTime? CheckedDtEng { get; set; }
        public int? AcceptedBy { get; set; }
        public string AcceptedDt { get; set; }
        public DateTime? AcceptedDtEng { get; set; }
        public string PurOrderDt { get; set; }
        public string DakhilaLastEntryDt { get; set; }
        public DateTime? PurOrderDtEng { get; set; }
        public string Isdakhila { get; set; }
        public string Remarks { get; set; }
        public int? Accountid { get; set; }
        public string PurchaseDecisionNo { get; set; }
        public string PurchaseDecisionDate { get; set; }

        public virtual PisEmployeeMaster AcceptedByNavigation { get; set; }
        public virtual PisEmployeeMaster CheckedByNavigation { get; set; }
        public virtual PisEmployeeMaster PreparedByNavigation { get; set; }
        public virtual InvSupplier Supp { get; set; }
        public virtual ICollection<InvPurOrderDetl> InvPurOrderDetl { get; set; }
    }
}
