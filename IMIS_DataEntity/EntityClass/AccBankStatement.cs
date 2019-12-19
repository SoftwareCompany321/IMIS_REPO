using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class AccBankStatement
    {
        public int? Id { get; set; }
        public int? BankId { get; set; }
        public string TransactionDate { get; set; }
        public DateTime? TransactionDateEn { get; set; }
        public string ChequeNo { get; set; }
        public string Description { get; set; }
        public float? DrAmt { get; set; }
        public float? CrAmt { get; set; }
        public int? BankTransactionId { get; set; }
        public float? Balance { get; set; }
    }
}
