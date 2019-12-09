using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemUnit;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemUnitController : Controller
    {
        private readonly IItemUnit _ItemUnit;

        public ItemUnitController(IItemUnit ItemUnit)
        {
            _ItemUnit = ItemUnit;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemUniterFetchData.html")]
        public async Task<JsonResult> ItemUniterFetchData(DataTableVm model)
        {
            var response = await _ItemUnit.ItemUnitFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemUniterlsit.html")]
        public IActionResult ItemUniterList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemUniterCreate.html")]
        public IActionResult ItemUniterCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemUniterCreate.html")]
        public IActionResult ItemUniterCreate(ItemUnitVM model)
        {
            return View();
        }
    }
}