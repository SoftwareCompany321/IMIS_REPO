using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisPyrollOthrDtls
    {
        public decimal Id { get; set; }
        public short? Month { get; set; }
        public decimal? EmployeeId { get; set; }
        public decimal? PayrollId { get; set; }
        public double? Amount { get; set; }
        public string AddSub { get; set; }
        public string Description { get; set; }
        public decimal? AccId { get; set; }
        public string SourceType { get; set; }

        public virtual PisEmployeeMaster Employee { get; set; }
        public virtual PisPayrolls Payroll { get; set; }
    }
}
