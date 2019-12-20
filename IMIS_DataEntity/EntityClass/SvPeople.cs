using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvPeople
    {
        public int Iid { get; set; }
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
        public int? Ocupationid { get; set; }
        public int? Religionid { get; set; }
        public int? Motherlanguageid { get; set; }
        public int? Nationalityid { get; set; }
        public short? Hascc { get; set; }
        public string Ccnumber { get; set; }
        public int? Ccissueddristictid { get; set; }
        public string Ccissueddate { get; set; }
        public int? Countryid { get; set; }
        public int? Zoneid { get; set; }
        public int? Districtid { get; set; }
        public int? Vdcid { get; set; }
        public int? Wardno { get; set; }
        public string Streetname { get; set; }
        public int? Trackid { get; set; }
        public string Houseno { get; set; }
        public string Corespaddressline1 { get; set; }
        public string Corespaddressline2 { get; set; }
        public string Corespaddressline3 { get; set; }
        public string Corespaddressline4 { get; set; }
        public string Otherdetails { get; set; }
        public int? Individualtype { get; set; }
        public string Photo { get; set; }
        public int? Userid { get; set; }
        public int? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public string IptUnpaidFiscalYear { get; set; }
        public float? IptUnpaidAmount { get; set; }
        public string HltUnpaidFiscalYear { get; set; }
        public float? HltUnpaidAmount { get; set; }
        public string IsUnpaidCleared { get; set; }
        public string CancelDate { get; set; }
        public string CancelReason { get; set; }
        public int? Tolbikashid { get; set; }
        public string IsLrmisAdd { get; set; }
    }
}
