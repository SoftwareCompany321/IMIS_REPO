using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvRequisitionMast
    {
        public InvRequisitionMast()
        {
            InvIssueMaster = new HashSet<InvIssueMaster>();
            InvReqDetail = new HashSet<InvReqDetail>();
        }

        public decimal Id { get; set; }
        public string ReqId { get; set; }
        public string ReqDateNep { get; set; }
        public decimal? ReqBy { get; set; }
        public decimal? TypeId { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? MaintainItemId { get; set; }
        public decimal? ProjId { get; set; }
        public decimal? HandoverId { get; set; }
        public decimal? HandoverRoomId { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }
        public decimal? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public decimal? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public decimal? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public string Orgstaffname { get; set; }
        public string Orgstaffpost { get; set; }
        public decimal? ReqType { get; set; }
        public decimal? Userid { get; set; }
        public decimal? VehicleId { get; set; }
        public string Reasion { get; set; }
        public DateTime? ReqDateEng { get; set; }
        public DateTime? PrepDtEng { get; set; }
        public DateTime? CheckDtEng { get; set; }
        public DateTime? AcceptDtEng { get; set; }
        public string PurchaseGive { get; set; }
        public string StockGive { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual PisEmployeeMaster CheckByNavigation { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvProject Proj { get; set; }
        public virtual PisEmployeeMaster ReqByNavigation { get; set; }
        public virtual ICollection<InvIssueMaster> InvIssueMaster { get; set; }
        public virtual ICollection<InvReqDetail> InvReqDetail { get; set; }
    }
}
