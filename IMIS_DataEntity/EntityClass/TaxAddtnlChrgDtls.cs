using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxAddtnlChrgDtls
    {
        public int Sn { get; set; }
        public string FiscalYear { get; set; }
        public int? Iid { get; set; }
        public int? Accode { get; set; }
        public int? AccId { get; set; }
        public int? Amount { get; set; }
        public int? LandId { get; set; }
        public int? RentId { get; set; }
        public float? ServiceChargePercent { get; set; }
        public float? FlatChargeRate { get; set; }
        public short? Isapplicableforhouse { get; set; }
        public string TaxType { get; set; }
        public string ServiceChargeType { get; set; }
        public string Isregistationfee { get; set; }
        public int? BillId { get; set; }
        public int? BillNo { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual Accode AccodeNavigation { get; set; }
    }
}
