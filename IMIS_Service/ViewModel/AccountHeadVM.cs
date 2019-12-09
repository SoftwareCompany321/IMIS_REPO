using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class AccountHeadVM
    {
        public decimal AccId { get; set; }
        public string Code { get; set; }
        public string NepName { get; set; }
        public string EngName { get; set; }
        public decimal? ParentAccId { get; set; }
        public int? GrpLevel { get; set; }
        public string IsFixed { get; set; }
        public string IsTransactable { get; set; }
        public string IsBudgetable { get; set; }
        public string DispCode { get; set; }
        public string DispName { get; set; }
        public string AccType { get; set; }
        public decimal? TypeId { get; set; }
        public string AccCode { get; set; }
        public decimal? SubModuleId { get; set; }
        public string FiscalYear { get; set; }
        public string IsHide { get; set; }
        public decimal? Iscapitalcurrent { get; set; }
    }
}
