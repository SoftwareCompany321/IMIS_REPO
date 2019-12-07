using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBankStatement
    {
        public decimal? Id { get; set; }
        public int? BankId { get; set; }
        public string TransactionDate { get; set; }
        public DateTime? TransactionDateEn { get; set; }
        public string ChequeNo { get; set; }
        public string Description { get; set; }
        public double? DrAmt { get; set; }
        public double? CrAmt { get; set; }
        public decimal? BankTransactionId { get; set; }
        public double? Balance { get; set; }
    }
}
