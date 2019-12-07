using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class IncomebilldetailsHistory
    {
        public decimal? Sn { get; set; }
        public decimal? SnIncomebilldtl { get; set; }
        public decimal? Billid { get; set; }
        public string Billno { get; set; }
        public string Billdate { get; set; }
        public decimal? Counterid { get; set; }
        public decimal? Personid { get; set; }
        public decimal? Accode { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vrno { get; set; }
        public string VchrDateNp { get; set; }
        public decimal? Orderinbill { get; set; }
        public string Remarks { get; set; }
        public decimal? VchrId { get; set; }
        public decimal? AccId { get; set; }
        public string FiscalYear { get; set; }
        public string Project { get; set; }
        public decimal? Taxaddtnlid { get; set; }
        public decimal? Qty { get; set; }
        public decimal? BudgetSourceId { get; set; }
        public string TaxType { get; set; }
        public decimal? BackupPersonid { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
