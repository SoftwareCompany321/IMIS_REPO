using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TaxAddtnlChrgDtls
    {
        public decimal Sn { get; set; }
        public string FiscalYear { get; set; }
        public decimal? Iid { get; set; }
        public decimal? Accode { get; set; }
        public decimal? AccId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? LandId { get; set; }
        public decimal? RentId { get; set; }
        public double? ServiceChargePercent { get; set; }
        public double? FlatChargeRate { get; set; }
        public short? Isapplicableforhouse { get; set; }
        public string TaxType { get; set; }
        public string ServiceChargeType { get; set; }
        public string Isregistationfee { get; set; }
        public decimal? BillId { get; set; }
        public decimal? BillNo { get; set; }

        public virtual AccAccMaster Acc { get; set; }
        public virtual Accode AccodeNavigation { get; set; }
    }
}
