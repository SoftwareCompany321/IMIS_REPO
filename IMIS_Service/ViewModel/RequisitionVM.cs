using IMIS_DataEntity.EntityClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class RequisitionVM

    {
        public RequisitionVM()
        {
            InvIssueMaster = new InvIssueMaster();
            InvReqDetail = new InvReqDetail();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string ReqId { get; set; }
        public string ReqDateNep { get; set; }
        public int? ReqBy { get; set; }
        public int? TypeId { get; set; }
        public int? ItemId { get; set; }
        public int? MaintainItemId { get; set; }
        public int? ProjId { get; set; }
        public int? HandoverId { get; set; }
        public int? HandoverRoomId { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }
        public int? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public int? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public int? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public string Orgstaffname { get; set; }
        public string Orgstaffpost { get; set; }
        public int? ReqType { get; set; }
        public int? Userid { get; set; }
        public int? VehicleId { get; set; }
        public string Reasion { get; set; }
        public DateTime? ReqDateEng { get; set; }
        public DateTime? PrepDtEng { get; set; }
        public DateTime? CheckDtEng { get; set; }
        public DateTime? AcceptDtEng { get; set; }
        public bool PurchaseGive { get; set; }
        public bool StockGive { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual PisEmployeeMaster CheckByNavigation { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvProject Proj { get; set; }
        public virtual PisEmployeeMaster ReqByNavigation { get; set; }
        public InvIssueMaster InvIssueMaster { get; set; }
        public InvReqDetail InvReqDetail { get; set; }

    }
}
