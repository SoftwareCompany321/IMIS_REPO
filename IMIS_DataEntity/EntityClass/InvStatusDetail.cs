using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvStatusDetail
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime? Statusdatead { get; set; }
        public string Statusdatevs { get; set; }
        public string FiscalYear { get; set; }
        public int? Totalqty { get; set; }
        public int? ItemId { get; set; }
        public int? BrandId { get; set; }
        public int? SpecId { get; set; }
        public int? ItemStatusId { get; set; }
        public string Remarks { get; set; }
        public int? Preby { get; set; }
        public string Prevsdate { get; set; }
        public int? Checkedby { get; set; }
        public string Checkvsdate { get; set; }
        public int? Acceptby { get; set; }
        public int? MainId { get; set; }
        public string Acceptvsdate { get; set; }

        public virtual PisEmployeeMaster AcceptbyNavigation { get; set; }
        public virtual PisEmployeeMaster CheckedbyNavigation { get; set; }
        public virtual PisEmployeeMaster PrebyNavigation { get; set; }
    }
}
