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

        public decimal Sn { get; set; }
        public string Billno { get; set; }
        public string Description { get; set; }
        public decimal? Counterid { get; set; }
        public decimal? Personid { get; set; }
        public string Billdate { get; set; }
        public decimal? Cashamount { get; set; }
        public decimal? Bankamount { get; set; }
        public decimal? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public decimal? Billtypeid { get; set; }
        public string Taxincometype { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public short? WardNo { get; set; }
        public string CancelDate { get; set; }
        public string CancelReason { get; set; }
        public string BillNoManual { get; set; }
        public string FiscalYear { get; set; }
        public string Project { get; set; }
        public decimal? SubModuleId { get; set; }
        public decimal? CurrencyId { get; set; }
        public decimal? BackupPersonid { get; set; }

        public virtual Tblbilltype Billtype { get; set; }
        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual ICollection<AccBankTrans> AccBankTrans { get; set; }
        public virtual ICollection<AccCashTrans> AccCashTrans { get; set; }
    }
}
