using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemPurchaseType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemPurchaseTypeController : Controller
    {
        private readonly IItemPurchaseType _ItemPurchaseType;

        public ItemPurchaseTypeController(IItemPurchaseType ItemPurchaseType)
        {
            _ItemPurchaseType = ItemPurchaseType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurchaseTypeFetchData.html")]
        public async Task<JsonResult> ItemPurchaseTypeFetchData(DataTableVm model)
        {
            var response = await _ItemPurchaseType.ItemPurchaseTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemPurchaseTypelsit.html")]
        public IActionResult ItemPurchaseTypeList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurchaseTypeCreate.html")]
        public IActionResult ItemPurchaseTypeCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurchaseTypeCreate.html")]
        public IActionResult ItemPurchaseTypeCreate(ItemPurchaseTypeVM model)
        {
            return View();
        }
    }
}