using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MalpotLands
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Iid { get; set; }
        public string Eid { get; set; }
        public string NpFirstname { get; set; }
        public string NpLastname { get; set; }
        public int? Oldvdcid { get; set; }
        public string Oldwordno { get; set; }
        public string Mothnumber { get; set; }
        public string Kittanumber { get; set; }
        public int? Vdcid { get; set; }
        public int? Wordno { get; set; }
        public float? Areainsqft { get; set; }
        public float? Nonfunctionalareainsqft { get; set; }
        public int? AddUserid { get; set; }
        public int? EditUserid { get; set; }
        public string AddDate { get; set; }
        public string EditDate { get; set; }
        public int? IsIpt { get; set; }
    }
}
