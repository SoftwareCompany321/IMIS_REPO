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
        [Route("/ItemPurchaseTypeerFetchData.html")]
        public async Task<JsonResult> ItemPurchaseTypeerFetchData(DataTableVm model)
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
        [Route("/ItemPurchaseTypeerlsit.html")]
        public IActionResult ItemPurchaseTypeerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemPurchaseTypeerCreate.html")]
        public IActionResult ItemPurchaseTypeerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemPurchaseTypeerCreate.html")]
        public IActionResult ItemPurchaseTypeerCreate(ItemPurchaseTypeVM model)
        {
            return View();
        }
    }
}