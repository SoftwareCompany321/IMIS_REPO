using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class BusinessmasterHistory
    {
        public int? Id { get; set; }
        public int? BizId { get; set; }
        public string Nepname { get; set; }
        public int? Businessgroupid { get; set; }
        public int? Taxpayerid { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
