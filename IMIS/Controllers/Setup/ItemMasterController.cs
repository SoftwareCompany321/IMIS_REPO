using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemMaster;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class ItemMasterController : Controller
    {
        private readonly IItemMaster _ItemMaster;

        public ItemMasterController(IItemMaster ItemMaster)
        {
            _ItemMaster = ItemMaster;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemMastererFetchData.html")]
        public async Task<JsonResult> ItemMastererFetchData(DataTableVm model)
        {
            var response = await _ItemMaster.ItemMasterFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/ItemMastererlsit.html")]
        public IActionResult ItemMastererList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemMastererCreate.html")]
        public IActionResult ItemMastererCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemMastererCreate.html")]
        public IActionResult ItemMastererCreate(ItemMasterVM model)
        {
            return View();
        }
    }
}