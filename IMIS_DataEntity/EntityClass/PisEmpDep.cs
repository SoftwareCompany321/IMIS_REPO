using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpDep
    {
        public PisEmpDep()
        {
            PisEmployeeMaster = new HashSet<PisEmployeeMaster>();
        }

        public int DeptId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public int SalaryAccId { get; set; }
        public int? AllowanceAccId { get; set; }
        public int? AddPfAccId { get; set; }
        public int? AddInsrnceAccId { get; set; }
        public int? SubPfAccId { get; set; }
        public int? SubInsrnceAccId { get; set; }
        public int? CitAccId { get; set; }
        public int? IncmeTaxAccId { get; set; }
        public int? LendPfDAccId { get; set; }
        public int? SocSecTax { get; set; }
        public int? BhattaAccId { get; set; }
        public int? PeskiKattiAccId { get; set; }
        public int? OthrKattiAccId { get; set; }
        public int? AbsntKattiAccId { get; set; }
        public int? SapatiKattiAccId { get; set; }
        public int? BudgetSourceId { get; set; }
        public int? TdsAccId { get; set; }
        public int? WorkId { get; set; }
        public int? BudjetSourceId { get; set; }

        public virtual PisEmpDepSource PisEmpDepSource { get; set; }
        public virtual ICollection<PisEmployeeMaster> PisEmployeeMaster { get; set; }
    }
}
