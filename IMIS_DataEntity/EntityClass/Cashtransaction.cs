using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class Cashtransaction
    {
        public int Sn { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? Dramount { get; set; }
        public int? Cramount { get; set; }
        public int? Incomeexptypeid { get; set; }
        public string Isoflastyear { get; set; }
        public string VchrDateNp { get; set; }
        public int? VchrId { get; set; }
        public int? Billid { get; set; }
        public string Module { get; set; }
        public int? SubmoduleTypeId { get; set; }
        public int? DhrtiMasterId { get; set; }
        public int? ExpSlipId { get; set; }
        public int? BudgetSourceId { get; set; }

        public virtual AccDhrtiBillMaster DhrtiMaster { get; set; }
        public virtual AccSubModuleType SubmoduleType { get; set; }
        public virtual AccVchrMaster Vchr { get; set; }
    }
}
