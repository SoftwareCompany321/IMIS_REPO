using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class OfficeAppPosVM
    {
        public int LocalPostId { get; set; }
        public string Code { get; set; }
        public string LocalPostName { get; set; }
        public string LocalPostNameEn { get; set; }
        public int? PostId { get; set; }
        public string PostDuties { get; set; }
        public float? BasicSalary { get; set; }
        public float? GradeRate { get; set; }
        public float? Allwance { get; set; }
        public float? InsuranceAddAmt { get; set; }
        public int? PayrollOrder { get; set; }
        public float? Alllwance { get; set; }
        public float? Allowance { get; set; }
    }
}
