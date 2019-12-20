using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccDhrtiBillMaster
    {
        public AccDhrtiBillMaster()
        {
            Banktransactions = new HashSet<Banktransactions>();
            Cashtransaction = new HashSet<Cashtransaction>();
        }

        public int DhrtiMasterId { get; set; }
        public string BillNo { get; set; }
        public string Description { get; set; }
        public int? CounterId { get; set; }
        public int? PersonId { get; set; }
        public string BllDateNp { get; set; }
        public float? CashAmt { get; set; }
        public float? BankAmt { get; set; }
        public int? VchrId { get; set; }
        public string VchrDateNp { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string DateEntryVsDate { get; set; }
        public DateTime? DateEntryTime { get; set; }
        public DateTime? DateEditTime { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public short? WardNo { get; set; }
        public string CancelDate { get; set; }
        public string CancelReason { get; set; }
        public string BillNoManual { get; set; }
        public string FiscalYear { get; set; }
        public int? Billtypeid { get; set; }
        public int? SubModuleId { get; set; }
        public int? WorkId { get; set; }

        public virtual Tblbilltype Billtype { get; set; }
        public virtual AccSubModuleType SubModule { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
        public virtual AccWorkMaster Work { get; set; }
        public virtual ICollection<Banktransactions> Banktransactions { get; set; }
        public virtual ICollection<Cashtransaction> Cashtransaction { get; set; }
    }
}
