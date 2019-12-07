using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class BusinessmasterHistory
    {
        public decimal? Id { get; set; }
        public decimal? BizId { get; set; }
        public string Nepname { get; set; }
        public decimal? Businessgroupid { get; set; }
        public decimal? Taxpayerid { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
