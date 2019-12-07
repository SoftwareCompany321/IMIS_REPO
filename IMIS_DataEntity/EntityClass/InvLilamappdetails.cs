using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class InvLilamappdetails
    {
        public decimal Id { get; set; }
        public decimal? Lilamappliid { get; set; }
        public decimal? Dakhilaid { get; set; }
        public decimal? Nikashaid { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Brandid { get; set; }
        public decimal? Specid { get; set; }
        public decimal? Lilamqty { get; set; }
        public double? Lilamtotalamt { get; set; }

        public virtual InvLilamAppmaster Lilamappli { get; set; }
    }
}
