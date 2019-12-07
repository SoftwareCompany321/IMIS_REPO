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

        public decimal Id { get; set; }
        public decimal? DakhilaId { get; set; }
        public string GdAdjId { get; set; }
        public string BudgetYear { get; set; }
        public string Month { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? ItemType { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public double? AdjQty { get; set; }
        public decimal? AdjTypeId { get; set; }
        public double? ItemAdjRate { get; set; }
        public string AdjDtNp { get; set; }
        public DateTime? AdjDtEng { get; set; }
        public string Remarks { get; set; }
        public decimal? PrepBy { get; set; }
        public string PrepDtNp { get; set; }
        public DateTime? PrepDtEng { get; set; }
        public decimal? AcceptBy { get; set; }
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
