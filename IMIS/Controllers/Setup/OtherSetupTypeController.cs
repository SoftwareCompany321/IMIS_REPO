using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMIS_CORE.Utility;
using IMIS_Service.Setup.IItemOtherSetupType;
using IMIS_Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IMIS.Controllers.Setup
{
    public class OtherSetupTypeController : Controller
    {
        private readonly IItemOtherSetupType _OtherSetupType;

        public OtherSetupTypeController(IItemOtherSetupType OtherSetupType)
        {
            _OtherSetupType = OtherSetupType;
        }
        //for the account head controller 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/OtherSetupTypeerFetchData.html")]
        public async Task<JsonResult> OtherSetupTypeerFetchData(DataTableVm model)
        {
            var response = await _OtherSetupType.ItemOtherSetupTypeFetchData(model);
            return Json(new
            {
                draw = response.draw,
                recordsTotal = response.TotalRecord,// 5,//totalResultsCount,
                recordsFiltered = response.FilteredRecord,// 5000,//filteredResultsCount,
                data = response.data
            });
        }

        [HttpGet]
        [Route("/OtherSetupTypeerlsit.html")]
        public IActionResult OtherSetupTypeerList()
        {
            return View();
        }

        [HttpGet]
        [Route("/OtherSetupTypeerCreate.html")]
        public IActionResult OtherSetupTypeerCreate()
        {
            return View();
        }

        [HttpPost]
        [Route("/OtherSetupTypeerCreate.html")]
        public IActionResult OtherSetupTypeerCreate(ItemOtherSetupTypeVM model)
        {
            return View();
        }
    }
}