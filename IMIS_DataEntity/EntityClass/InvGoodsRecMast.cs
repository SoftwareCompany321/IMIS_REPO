using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvGoodsRecMast
    {
        public InvGoodsRecMast()
        {
            InvGoodsRecDetl = new HashSet<InvGoodsRecDetl>();
            InvItemDetails = new HashSet<InvItemDetails>();
        }

        public int Id { get; set; }
        public string DakhilaId { get; set; }
        public int? PurMasterId { get; set; }
        public int? RepairId { get; set; }
        public string DakhilaDt { get; set; }
        public int? WarehouseId { get; set; }
        public string InvBillNo { get; set; }
        public string InvDate { get; set; }
        public string DetailsNep { get; set; }
        public string DetailsEng { get; set; }
        public int? PrepBy { get; set; }
        public string PrepDt { get; set; }
        public int? CheckBy { get; set; }
        public string CheckDt { get; set; }
        public int? AcceptBy { get; set; }
        public string AcceptDt { get; set; }
        public DateTime? DakhilaDtEng { get; set; }
        public DateTime? InvDateEng { get; set; }
        public DateTime? PrepDtEng { get; set; }
        public DateTime? CheckDtEng { get; set; }
        public DateTime? AcceptDtEng { get; set; }
        public string FiscalYear { get; set; }
        public int? PaymentId { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual PisEmployeeMaster CheckByNavigation { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual ICollection<InvGoodsRecDetl> InvGoodsRecDetl { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetails { get; set; }
    }
}
