using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBankGrnty
    {
        public int GrntyId { get; set; }
        public string GrntyNo { get; set; }
        public string GrntyVsDate { get; set; }
        public string BankName { get; set; }
        public float? GrntyAmount { get; set; }
        public string GrntyType { get; set; }
        public int? WorkId { get; set; }
        public int? PersonId { get; set; }
        public string PhukuwaPs { get; set; }
        public string PhukuwaCn { get; set; }
        public string PhukuwaVsDate { get; set; }
        public string MagPs { get; set; }
        public string MagCn { get; set; }
        public string MagVsDate { get; set; }
        public DateTime? EntryDatetime { get; set; }
        public string ExpryVsDate { get; set; }

        public virtual AccOrgMaster Person { get; set; }
        public virtual AccWorkMaster Work { get; set; }
    }
}
