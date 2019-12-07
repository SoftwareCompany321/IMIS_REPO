using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvPeople
    {
        public decimal Iid { get; set; }
        public string Eid { get; set; }
        public short? Sex { get; set; }
        public string Firstnepname { get; set; }
        public string Lastnepname { get; set; }
        public string Firstengname { get; set; }
        public string Lastengname { get; set; }
        public string Dob { get; set; }
        public string Fatherorhusband { get; set; }
        public string Gforfinlaw { get; set; }
        public string Phones { get; set; }
        public string Mobiles { get; set; }
        public string Email { get; set; }
        public decimal? Ocupationid { get; set; }
        public decimal? Religionid { get; set; }
        public decimal? Motherlanguageid { get; set; }
        public decimal? Nationalityid { get; set; }
        public short? Hascc { get; set; }
        public string Ccnumber { get; set; }
        public decimal? Ccissueddristictid { get; set; }
        public string Ccissueddate { get; set; }
        public decimal? Countryid { get; set; }
        public decimal? Zoneid { get; set; }
        public decimal? Districtid { get; set; }
        public decimal? Vdcid { get; set; }
        public decimal? Wardno { get; set; }
        public string Streetname { get; set; }
        public decimal? Trackid { get; set; }
        public string Houseno { get; set; }
        public string Corespaddressline1 { get; set; }
        public string Corespaddressline2 { get; set; }
        public string Corespaddressline3 { get; set; }
        public string Corespaddressline4 { get; set; }
        public string Otherdetails { get; set; }
        public decimal? Individualtype { get; set; }
        public string Photo { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public string IptUnpaidFiscalYear { get; set; }
        public double? IptUnpaidAmount { get; set; }
        public string HltUnpaidFiscalYear { get; set; }
        public double? HltUnpaidAmount { get; set; }
        public string IsUnpaidCleared { get; set; }
        public string CancelDate { get; set; }
        public string CancelReason { get; set; }
        public decimal? Tolbikashid { get; set; }
        public string IsLrmisAdd { get; set; }
    }
}
