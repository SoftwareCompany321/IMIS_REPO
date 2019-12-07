using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class MalpotLands
    {
        public decimal Id { get; set; }
        public decimal? Iid { get; set; }
        public string Eid { get; set; }
        public string NpFirstname { get; set; }
        public string NpLastname { get; set; }
        public decimal? Oldvdcid { get; set; }
        public string Oldwordno { get; set; }
        public string Mothnumber { get; set; }
        public string Kittanumber { get; set; }
        public decimal? Vdcid { get; set; }
        public decimal? Wordno { get; set; }
        public double? Areainsqft { get; set; }
        public double? Nonfunctionalareainsqft { get; set; }
        public decimal? AddUserid { get; set; }
        public decimal? EditUserid { get; set; }
        public string AddDate { get; set; }
        public string EditDate { get; set; }
        public decimal? IsIpt { get; set; }
    }
}
