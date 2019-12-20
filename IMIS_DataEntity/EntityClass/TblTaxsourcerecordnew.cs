using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblTaxsourcerecordnew
    {
        public int Taxsrcid { get; set; }
        public string Fiscalyear { get; set; }
        public int? Recordtype { get; set; }
        public int? NetincomeCurfy { get; set; }
        public int? TaxpaidtaxpayercntCurfy { get; set; }
        public int? NetincomeLastfy { get; set; }
        public int? TaxpaidtaxpayercntLastfy { get; set; }
        public int? Taxnotpaidtaxpayercnt { get; set; }
        public int? Amountnotcollected { get; set; }
        public int? Totaltaxpayercnt { get; set; }
    }
}
