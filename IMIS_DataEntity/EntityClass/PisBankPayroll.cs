using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisBankPayroll
    {
        public int Sn { get; set; }
        public int? EmpId { get; set; }
        public int? BankId { get; set; }
        public string BankFolio { get; set; }
        public string AccountNo { get; set; }

        public virtual Bankmaster Bank { get; set; }
        public virtual PisEmployeeMaster Emp { get; set; }
    }
}
