using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPyrollOthrDtls
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public short? Month { get; set; }
        public int? EmployeeId { get; set; }
        public int? PayrollId { get; set; }
        public float? Amount { get; set; }
        public string AddSub { get; set; }
        public string Description { get; set; }
        public int? AccId { get; set; }
        public string SourceType { get; set; }

        public virtual PisEmployeeMaster Employee { get; set; }
        public virtual PisPayrolls Payroll { get; set; }
    }
}
