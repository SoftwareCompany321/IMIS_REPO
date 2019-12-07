using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemStatuscheck
    {
        public decimal Id { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? BrandId { get; set; }
        public string InspStDate { get; set; }
        public DateTime? InspStDateEng { get; set; }
        public string InspEdDate { get; set; }
        public DateTime? InspEdDateEng { get; set; }
        public decimal? StkMstCount { get; set; }
        public string CountYesNo { get; set; }
        public decimal? StkCurCount { get; set; }
        public string CountUpDown { get; set; }
        public string InspectDate { get; set; }
        public DateTime? InspectDateEng { get; set; }
        public string UpDownDetail { get; set; }
        public string Remarks { get; set; }
        public decimal? PrepBy { get; set; }
        public string PrepDate { get; set; }
        public DateTime? PrepDateEng { get; set; }
        public decimal? TallyBy { get; set; }
        public string CheckedDate { get; set; }
        public decimal? CheckQty { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? CheckedDateEng { get; set; }
        public decimal? AcceptedBy { get; set; }
        public string AcceptedDate { get; set; }
        public DateTime? AcceptedDateEng { get; set; }
        public string FisicalYear { get; set; }
        public string IsActive { get; set; }
        public decimal? UpDownNo { get; set; }
        public string CheckStatus { get; set; }

        public virtual PisEmployeeMaster AcceptedByNavigation { get; set; }
        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvItemSpec Spec { get; set; }
        public virtual PisEmployeeMaster TallyByNavigation { get; set; }
    }
}
