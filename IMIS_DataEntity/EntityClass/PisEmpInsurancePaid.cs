using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpInsurancePaid
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public float? Amount { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }
    }
}
