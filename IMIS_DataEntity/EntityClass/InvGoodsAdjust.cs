using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvGoodsAdjust
    {
        public InvGoodsAdjust()
        {
            InvItemDetails = new HashSet<InvItemDetails>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? DakhilaId { get; set; }
        public string GdAdjId { get; set; }
        public string BudgetYear { get; set; }
        public string Month { get; set; }
        public int? ItemId { get; set; }
        public int? ItemType { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public float? AdjQty { get; set; }
        public int? AdjTypeId { get; set; }
        public float? ItemAdjRate { get; set; }
        public string AdjDtNp { get; set; }
        public DateTime? AdjDtEng { get; set; }
        public string Remarks { get; set; }
        public int? PrepBy { get; set; }
        public string PrepDtNp { get; set; }
        public DateTime? PrepDtEng { get; set; }
        public int? AcceptBy { get; set; }
        public string AcceptDtNp { get; set; }
        public DateTime? AcceptDtEng { get; set; }

        public virtual PisEmployeeMaster AcceptByNavigation { get; set; }
        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvItemSpec Spec { get; set; }
        public virtual ICollection<InvItemDetails> InvItemDetails { get; set; }
    }
}
