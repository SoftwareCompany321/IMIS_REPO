using System;
using System.Collections.Generic;
using System.Text;

namespace IMIS_Service.ViewModel
{
    public class ItemCategoriesVM
    {
        public ItemCategoriesVM()
        {

            itemCatSub = new List<ItemCatSub>();
        }
        public int Id { get; set; } 
        public string NameNp { get; set; }
        public string NameEn { get; set; }
        public int? ParentId { get; set; }
        public int? GrpLevel { get; set; }
        public int? IsHeader { get; set; }
        public bool Isexp { get; set; }
        public short? Islast { get; set; }
        public string Code { get; set; }
        public int? Unit { get; set; }
        public int? Minl { get; set; }
        public int? Maxl { get; set; }
        public int? Rminl { get; set; }
        public int? Rmaxl { get; set; }
        public decimal? DepreciationPer { get; set; }
        public decimal? DepreciationMin { get; set; }
        public decimal? DepreciationMax { get; set; }
        public string Remarks { get; set; }
        public int? ItemId { get; set; }
        public List<ItemCatSub>  itemCatSub { get; set; }
         
    }

    public class ItemCatSub: ItemCategoriesVM
    {

    }

}
