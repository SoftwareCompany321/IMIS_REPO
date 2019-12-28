using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamappdetails
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Lilamappliid { get; set; }
        public int? Dakhilaid { get; set; }
        public int? Nikashaid { get; set; }
        public int? Itemid { get; set; }
        public int? Unitid { get; set; }
        public int? Brandid { get; set; }
        public int? Specid { get; set; }
        public int? Lilamqty { get; set; }
        public float? Lilamtotalamt { get; set; }

        public virtual InvLilamAppmaster Lilamappli { get; set; }
    }
}
