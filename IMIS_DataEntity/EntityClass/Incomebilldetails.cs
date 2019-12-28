using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Incomebilldetails
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public int? Billid { get; set; }
        public string Billno { get; set; }
        public string Billdate { get; set; }
        public int? Counterid { get; set; }
        public int? Personid { get; set; }
        public int? Accode { get; set; }
        public int? Amount { get; set; }
        public string VchrDateNp { get; set; }
        public int? Orderinbill { get; set; }
        public string Remarks { get; set; }
        public int? VchrId { get; set; }
        public int? AccId { get; set; }
        public string FiscalYear { get; set; }
        public string Project { get; set; }
        public int? Taxaddtnlid { get; set; }
        public string TaxType { get; set; }
        public int? Qty { get; set; }
        public int? BudgetSourceId { get; set; }
        public int? BackupPersonid { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
