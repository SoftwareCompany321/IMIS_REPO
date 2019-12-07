using System;
using System.Collections.Generic;

namespace IMIS_DataEntity.EntityClass
{
    public partial class SvVehiclemaster
    {
        public decimal Sn { get; set; }
        public decimal? Taxpayerid { get; set; }
        public string Vehiclename { get; set; }
        public decimal? Vehicletype { get; set; }
        public string Vehicleno { get; set; }
        public string Registeredoffice { get; set; }
        public string Registereddate { get; set; }
        public string Municipaltyregno { get; set; }
        public string Municipaltyregdate { get; set; }
        public decimal? Aquisitiontype { get; set; }
        public string Aquisitiondate { get; set; }
        public string Aquiredfrom { get; set; }
        public decimal? Usestype { get; set; }
        public string Color { get; set; }
        public string Numberofseates { get; set; }
        public string Ccorhprspower { get; set; }
        public string Madeof { get; set; }
        public string Engineno { get; set; }
        public string Chesisno { get; set; }
        public string Modeldescription { get; set; }
        public string Noofcilenders { get; set; }
        public decimal? Usedfuel { get; set; }
        public string Specialnotes { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Useride { get; set; }
        public string Dataentryvsdate { get; set; }
        public DateTime? Dataentryaddatetime { get; set; }
        public DateTime? Dataeditaddatetime { get; set; }
        public short? VehicleStatus { get; set; }
        public string ClosedVsDate { get; set; }
        public string CloseReason { get; set; }
        public string PaidLastFiscalyear { get; set; }
        public string Namasarimiti { get; set; }
        public decimal? Namasaritaxpayerid { get; set; }
    }
}
