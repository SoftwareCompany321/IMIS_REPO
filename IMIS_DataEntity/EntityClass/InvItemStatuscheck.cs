using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvItemStatuscheck
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public int? SpecId { get; set; }
        public int? BrandId { get; set; }
        public string InspStDate { get; set; }
        public DateTime? InspStDateEng { get; set; }
        public string InspEdDate { get; set; }
        public DateTime? InspEdDateEng { get; set; }
        public int? StkMstCount { get; set; }
        public string CountYesNo { get; set; }
        public int? StkCurCount { get; set; }
        public string CountUpDown { get; set; }
        public string InspectDate { get; set; }
        public DateTime? InspectDateEng { get; set; }
        public string UpDownDetail { get; set; }
        public string Remarks { get; set; }
        public int? PrepBy { get; set; }
        public string PrepDate { get; set; }
        public DateTime? PrepDateEng { get; set; }
        public int? TallyBy { get; set; }
        public string CheckedDate { get; set; }
        public int? CheckQty { get; set; }
        public int? Rate { get; set; }
        public DateTime? CheckedDateEng { get; set; }
        public int? AcceptedBy { get; set; }
        public string AcceptedDate { get; set; }
        public DateTime? AcceptedDateEng { get; set; }
        public string FisicalYear { get; set; }
        public string IsActive { get; set; }
        public int? UpDownNo { get; set; }
        public string CheckStatus { get; set; }

        public virtual PisEmployeeMaster AcceptedByNavigation { get; set; }
        public virtual InvBrand Brand { get; set; }
        public virtual InvItemMst Item { get; set; }
        public virtual PisEmployeeMaster PrepByNavigation { get; set; }
        public virtual InvItemSpec Spec { get; set; }
        public virtual PisEmployeeMaster TallyByNavigation { get; set; }
    }
}
