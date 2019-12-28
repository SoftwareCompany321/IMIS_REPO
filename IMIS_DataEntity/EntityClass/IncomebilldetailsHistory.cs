using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class IncomebilldetailsHistory
    {
        public int? Sn { get; set; }
        public string Code { get; set; }
        public int? SnIncomebilldtl { get; set; }
        public int? Billid { get; set; }
        public string Billno { get; set; }
        public string Billdate { get; set; }
        public int? Counterid { get; set; }
        public int? Personid { get; set; }
        public int? Accode { get; set; }
        public int? Amount { get; set; }
        public int? Vrno { get; set; }
        public string VchrDateNp { get; set; }
        public int? Orderinbill { get; set; }
        public string Remarks { get; set; }
        public int? VchrId { get; set; }
        public int? AccId { get; set; }
        public string FiscalYear { get; set; }
        public string Project { get; set; }
        public int? Taxaddtnlid { get; set; }
        public int? Qty { get; set; }
        public int? BudgetSourceId { get; set; }
        public string TaxType { get; set; }
        public int? BackupPersonid { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
