using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccSubModuleType
    {
        public AccSubModuleType()
        {
            AccDhrtiBillMaster = new HashSet<AccDhrtiBillMaster>();
            AccPaymentMaster = new HashSet<AccPaymentMaster>();
            AccVchrDetails = new HashSet<AccVchrDetails>();
            AccVchrMaster = new HashSet<AccVchrMaster>();
            Banktransactions = new HashSet<Banktransactions>();
            Cashtransaction = new HashSet<Cashtransaction>();
            Incomebillmaster = new HashSet<Incomebillmaster>();
            SubModuleSource = new HashSet<SubModuleSource>();
        }

        public decimal SubModuleId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string Module { get; set; }
        public string Code { get; set; }
        public decimal? Iscapital { get; set; }
        public string BudgetAccNo { get; set; }
        public decimal? Isexpences { get; set; }
        public string AccExpencesCode { get; set; }

        public virtual ICollection<AccDhrtiBillMaster> AccDhrtiBillMaster { get; set; }
        public virtual ICollection<AccPaymentMaster> AccPaymentMaster { get; set; }
        public virtual ICollection<AccVchrDetails> AccVchrDetails { get; set; }
        public virtual ICollection<AccVchrMaster> AccVchrMaster { get; set; }
        public virtual ICollection<Banktransactions> Banktransactions { get; set; }
        public virtual ICollection<Cashtransaction> Cashtransaction { get; set; }
        public virtual ICollection<Incomebillmaster> Incomebillmaster { get; set; }
        public virtual ICollection<SubModuleSource> SubModuleSource { get; set; }
    }
}
