using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvStatusDetail
    {
        public decimal Id { get; set; }
        public string Code { get; set; }
        public DateTime? Statusdatead { get; set; }
        public string Statusdatevs { get; set; }
        public string FiscalYear { get; set; }
        public decimal? Totalqty { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? BrandId { get; set; }
        public decimal? SpecId { get; set; }
        public decimal? ItemStatusId { get; set; }
        public string Remarks { get; set; }
        public decimal? Preby { get; set; }
        public string Prevsdate { get; set; }
        public decimal? Checkedby { get; set; }
        public string Checkvsdate { get; set; }
        public decimal? Acceptby { get; set; }
        public decimal? MainId { get; set; }
        public string Acceptvsdate { get; set; }

        public virtual PisEmployeeMaster AcceptbyNavigation { get; set; }
        public virtual PisEmployeeMaster CheckedbyNavigation { get; set; }
        public virtual PisEmployeeMaster PrebyNavigation { get; set; }
    }
}
