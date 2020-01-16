using IMIS_DataEntity.EntityClass;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemMasterVM: InvItemMst
    {
        public List<SelectListItem> fuelmaintenance { set; get; }
        public List<SelectListItem> landdesc { set; get; }
        public List<SelectListItem> unitlist { set; get; }
        public List<SelectListItem> ItemCategorylist { set; get; }
        public List<SelectListItem> ItemSubCategoryList { set; get; }
        public List<SelectListItem> ItemNatureList { set; get; }
        public List<SelectListItem> CountryList { set; get; }
    }
}