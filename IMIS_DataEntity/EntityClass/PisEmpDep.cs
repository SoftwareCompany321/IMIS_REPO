using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class PisEmpDep
    {
        public PisEmpDep()
        {
            PisEmpDepSource = new HashSet<PisEmpDepSource>();
            PisEmployeeMaster = new HashSet<PisEmployeeMaster>();
        }

        public decimal DeptId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Description { get; set; }
        public decimal SalaryAccId { get; set; }
        public decimal? AllowanceAccId { get; set; }
        public decimal? AddPfAccId { get; set; }
        public decimal? AddInsrnceAccId { get; set; }
        public decimal? SubPfAccId { get; set; }
        public decimal? SubInsrnceAccId { get; set; }
        public decimal? CitAccId { get; set; }
        public decimal? IncmeTaxAccId { get; set; }
        public decimal? LendPfDAccId { get; set; }
        public decimal? SocSecTax { get; set; }
        public decimal? BhattaAccId { get; set; }
        public decimal? PeskiKattiAccId { get; set; }
        public decimal? OthrKattiAccId { get; set; }
        public decimal? AbsntKattiAccId { get; set; }
        public decimal? SapatiKattiAccId { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public decimal? TdsAccId { get; set; }
        public decimal? WorkId { get; set; }
        public decimal? BudjetSourceId { get; set; }

        public virtual ICollection<PisEmpDepSource> PisEmpDepSource { get; set; }
        public virtual ICollection<PisEmployeeMaster> PisEmployeeMaster { get; set; }
    }
}
