using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemMasterVM
    {
        public int ItemId { get; set; }
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? UnitId { get; set; }
        public int? ItemMainClass { get; set; }
        public int? ItemType { get; set; }
        public int? ItemNature { get; set; }
        public int? Maxl { get; set; }
        public int? Minl { get; set; }
        public int? Rmaxl { get; set; }
        public int? Rminl { get; set; }
        public int? Gussage { get; set; }
        public int? Sizes { get; set; }
        public int? Countryid { get; set; }
        public string Companyname { get; set; }
        public string Source { get; set; }
        public string Remarks { get; set; }
        public string Code { get; set; }
        public string KittaNo { get; set; }
        public string LandLocation { get; set; }
        public string Constructontype { get; set; }
        public float? Depreciation { get; set; }
        public float? Minrate { get; set; }
        public float? Depmaxrate { get; set; }
        public int? Propertytype { get; set; }
        public int? LandAreaInsqFeets { get; set; }
        public int? AreaInsqFeets { get; set; }
        public int? LandUnitRate { get; set; }
        public int? LandMarketRate { get; set; }
        public int? Landid { get; set; }
        public int? AccId { get; set; }
        public int? BudgetAccId { get; set; }
        public int? VehiclePartsId { get; set; }
    }
}
