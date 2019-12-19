using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvSupplier
    {
        public InvSupplier()
        {
            InvPurOrderMast = new HashSet<InvPurOrderMast>();
        }

        public int SupId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public string CompanyNameNp { get; set; }
        public string CompanyNameEn { get; set; }
        public string RegiType { get; set; }
        public string TpinPanNo { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string DateVs { get; set; }
        public DateTime? DateAd { get; set; }
        public string OrgType { get; set; }
        public int? OrgId { get; set; }
        public string IsSelected { get; set; }
        public string RegNo { get; set; }
        public string SupType { get; set; }

        public virtual ICollection<InvPurOrderMast> InvPurOrderMast { get; set; }
    }
}
