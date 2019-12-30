using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class BankDtlVM
    {
        public int Bankid { get; set; }
        public string Code { get; set; }
        public string Engname { get; set; }
        public string Nepname { get; set; }
        public string Bankcode { get; set; }
        public int? SubModuleId { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public string Emails { get; set; }
        public string Accountnumber { get; set; }
        public string Branchcode { get; set; }
        public string Trancode { get; set; }
        public string Cycode { get; set; }
        public int? FinancelInstituteId { get; set; }
        public string Branch { get; set; }
        public string Bankname { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
