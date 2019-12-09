using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IWareHouse;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class WareHouseController : Controller
    {
        private readonly IWareHouse _WareHouse;

        public WareHouseController(IWareHouse WareHouse)
        {
            _WareHouse = WareHouse;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/WareHouseerFetchData.html")]
        public async Task<JsonResult> WareHouseerFetchData(DataTableVm model)
        {
            var response = await _WareHouse.WareHouseFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/WareHouseerlsit.html")]
        public IActionResult WareHouseerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/WareHouseerCreate.html")]
        public IActionResult WareHouseerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/WareHouseerCreate.html")]
        public IActionResult WareHouseerCreate(WareHouseVM model)
        {
            return View();
        }
    }
}