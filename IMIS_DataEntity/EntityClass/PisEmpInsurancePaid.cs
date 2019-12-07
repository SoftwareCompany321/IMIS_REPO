using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpInsurancePaid
    {
        public decimal Id { get; set; }
        public decimal? EmpId { get; set; }
        public double? Amount { get; set; }
        public string FiscalYear { get; set; }
        public string Remarks { get; set; }
    }
}
