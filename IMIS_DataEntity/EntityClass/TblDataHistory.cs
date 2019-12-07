using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class TblDataHistory
    {
        public decimal Id { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
        public decimal? UserIdA { get; set; }
        public DateTime? AddDate { get; set; }
        public string ComputerName { get; set; }
        public string DataStatus { get; set; }
        public string WindowsUser { get; set; }
        public string TranTime { get; set; }
    }
}
