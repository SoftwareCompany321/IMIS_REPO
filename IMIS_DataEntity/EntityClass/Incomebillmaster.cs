using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Incomebillmaster
    {
        public Incomebillmaster()
        {
            AccBankTrans = new HashSet<AccBankTrans>();
            AccCashTrans = new HashSet<AccCashTrans>();
        }

        public int Sn { get; set; }
        public string Code { get; set; }
        public string Billno { get; set; }
        public string Description { get; set; }
        public int? Counterid { get; set; }
        public int? Personid { get; set; }
        public string Billdate { get; set; }
        public int? Cashamount { get; set; }
        public int? Bankamount { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public int? Billtypeid { get; set; }
        public string Taxincometype { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public short? WardNo { get; set; }
        public string CancelDate { get; set; }
        public string CancelReason { get; set; }
        public string BillNoManual { get; set; }
        public string FiscalYear { get; set; }
        public string Project { get; set; }
        public int? SubModuleId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BackupPersonid { get; set; }

        public virtual Tblbilltype Billtype { get; set; }
        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual ICollection<AccBankTrans> AccBankTrans { get; set; }
        public virtual ICollection<AccCashTrans> AccCashTrans { get; set; }
    }
}
