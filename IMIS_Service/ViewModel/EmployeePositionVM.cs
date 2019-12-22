using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class EmployeePositionVM
    {
        public int PostId { get; set; }
        public string GeneralPost { get; set; }
        public string GeneralPostShort { get; set; }
        public int? PostLevel { get; set; }
        public float? BasicSalary { get; set; }
        public int? RateOfGrade { get; set; }
        public int? MaxGradeRate { get; set; }
        public int? PrabidikOrPrasasan { get; set; }
    }
}
