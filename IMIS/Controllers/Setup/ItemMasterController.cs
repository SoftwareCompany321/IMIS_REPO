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
        [Route("/ItemMasterFetchData.html")]
        public async Task<JsonResult> ItemMasterFetchData(DataTableVm model)
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
        [Route("/ItemMasterlsit.html")]
        public IActionResult ItemMasterList()
        {
            return View();
        }

        [HttpGet]
        [Route("/ItemMasterCreate.html")]
        public IActionResult ItemMasterCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/ItemMasterCreate.html")]
        public IActionResult ItemMasterCreate(ItemMasterVM model)
        {
            return View();
        }
    }
}