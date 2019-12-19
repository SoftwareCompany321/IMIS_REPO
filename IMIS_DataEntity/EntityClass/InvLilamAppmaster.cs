using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamAppmaster
    {
        public InvLilamAppmaster()
        {
            InvLilamappdetails = new HashSet<InvLilamappdetails>();
        }

        public int Id { get; set; }
        public int? Appno { get; set; }
        public int? Projid { get; set; }
        public int? Applylilamid { get; set; }
        public string Orgapplicantname { get; set; }
        public string Orgapplicantpost { get; set; }
        public string Applydate { get; set; }
        public DateTime? Applyengdate { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<InvLilamappdetails> InvLilamappdetails { get; set; }
    }
}
