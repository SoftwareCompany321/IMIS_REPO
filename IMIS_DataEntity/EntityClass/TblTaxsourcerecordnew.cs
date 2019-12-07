using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblTaxsourcerecordnew
    {
        public decimal Taxsrcid { get; set; }
        public string Fiscalyear { get; set; }
        public decimal? Recordtype { get; set; }
        public decimal? NetincomeCurfy { get; set; }
        public decimal? TaxpaidtaxpayercntCurfy { get; set; }
        public decimal? NetincomeLastfy { get; set; }
        public decimal? TaxpaidtaxpayercntLastfy { get; set; }
        public decimal? Taxnotpaidtaxpayercnt { get; set; }
        public decimal? Amountnotcollected { get; set; }
        public decimal? Totaltaxpayercnt { get; set; }
    }
}
